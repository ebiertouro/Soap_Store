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
    public partial class Confirmation : Form
    {
        Customer user;
        private DataClasses1DataContext db;
        Invoice invoice;

        public Confirmation(Customer User, Invoice Invoice)
        {
            user = User;
            invoice = Invoice;
            InitializeComponent();
            InitializeDataContext();

        }
        private void InitializeDataContext()
        {
            // Initialize your LINQ to SQL data context
            db = new DataClasses1DataContext();
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            var dashboard = new Shop(user);
            dashboard.Show();
            this.Hide();
        }

        private void view_cart_btn_Click(object sender, EventArgs e)
        {
            var cart = new Cart(user);
            cart.Show();
            this.Hide();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            var home = new My_Account(user);
            home.Show();
            this.Hide();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            // Retrieve the product details from the database based on the product ID in the invoice
            var productDetails = db.Products
                .Where(p => p.product_id == invoice.product_id)
                .Select(p => new
                {
                    ProductName = p.description,
                    Price = p.price
                })
                .FirstOrDefault();

            // Construct the product information string
            string productInfo = $"Product: {productDetails?.ProductName ?? "N/A"}\n" +
                                 $"Price: {(productDetails != null ? productDetails.Price.ToString() : "N/A")}\n" +
                                 $"Quantity: {invoice.quantity}\n" +
                                 $"Total Price: {(productDetails != null ? (invoice.quantity * productDetails.Price).ToString() : "N/A")}\n" +
                                 $"Date: {invoice.Date}";

            // Update the product_info_label with the constructed product information
            product_info_label.Text = productInfo;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
