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
    public partial class Display_Purchases : Form
    {
        List<Invoice> purchases;
        Customer user;
        private DataClasses1DataContext db;
        public Display_Purchases(List<Invoice> Purchases, Customer User)
        {
            user = User;
            purchases = Purchases;
            InitializeComponent(); InitializeDataContext();
        }
        private void InitializeDataContext()
        {
            // Initialize your LINQ to SQL data context
            db = new DataClasses1DataContext();
        }

        private void Display_Purchases_Load(object sender, EventArgs e)
        {

            // Join Invoices and Products tables on the product_id key
            var query = purchases
                .Join(db.Products,
                    invoice => invoice.product_id,
                    product => product.product_id,
                    (invoice, product) => new
                    {
                        Name = product.description,
                        Price = invoice.total_price,
                        Quantity = invoice.quantity,
                        Date = invoice.Date,
                    })
                .ToList();

            // Set the DataSource of the DataGridView to the query result
            invoice_displayer.DataSource = query;
        }


        private void home_btn_Click(object sender, EventArgs e)
        {
            var home = new My_Account(user);
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
