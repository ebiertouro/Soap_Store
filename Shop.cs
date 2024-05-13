using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class Shop : Form
    {
        private DataClasses1DataContext db;
        Invoice invoice;
        Customer user;
        bool begin_shopping;
        int quantity;
        decimal cost;

        public Shop(Customer User)
        {
            user = User;
            InitializeComponent();
            InitializeDataContext();
            InitializeComboBox();
            // Attach event handlers
            product_selector.SelectedIndexChanged += new EventHandler(product_selector_SelectedIndexChanged);
            product_selector.LostFocus += new EventHandler(product_selector_LostFocus); // Adding LostFocus event handler
            invoice = new Invoice();
        }

        private void InitializeComboBox()
        {
            // Query the database to fetch product names and IDs
            var productsQuery = db.Products.OrderBy(p => p.description);

            // Bind the query result to the ComboBox
            product_selector.DataSource = productsQuery.ToList();

            // Specify the display member
            product_selector.DisplayMember = "description";
            // Specify the value member (assuming product_id is the primary key)
            product_selector.ValueMember = "product_id";
        }

        private void InitializeDataContext()
        {
            // Initialize your LINQ to SQL data context
            db = new DataClasses1DataContext();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soap_products.Products' table.
            // You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.soap_products.Products);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            var home = new My_Account(user);
            home.Show();
            this.Hide();
        }

        private void product_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (begin_shopping)
            {
                // Get the selected product from the ComboBox
                Product selectedProduct = (Product)product_selector.SelectedItem;

                // Check if a product is selected
                if (selectedProduct != null)
                {
                    // Display a message box with product details
                    MessageBox.Show($"Description: {selectedProduct.description}\n" +
                                    $"Product ID: {selectedProduct.product_id}\n" +
                                    $"Price: {selectedProduct.price:C}",
                                    "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set the product ID for the invoice (dummy value for testing)
                    invoice.product_id = selectedProduct.product_id;
                    cost = selectedProduct.price ?? 0;
                }
            }
        }


        private void quantity_selector_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)quantity_selector.Value;
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            if (user.balance > 250)
            {
                MessageBox.Show("You cannot add items to your cart due to overdue charges." +
                    "\nPlease return to your homepage and pay your balance.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Populate the invoice details
                invoice.customer_id = user.customer_id;
                invoice.quantity = quantity; // Assign the quantity
                invoice.total_price = quantity * cost; // Calculate the total price
                invoice.Date = DateTime.Now;

                // Insert the invoice into the database
                db.InsertInvoices(invoice);

                // Update user balance
                user.balance += invoice.total_price;

                // Show confirmation message
                var confirmation = new Confirmation(user, invoice);
                confirmation.Show();
                this.Hide();
            }
        }



        private void product_selector_LostFocus(object sender, EventArgs e)
        {
            // Set focus to another control to prevent interruption of user interactions
            quantity_selector.Focus();
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            begin_shopping = true;
        }
    }
}
