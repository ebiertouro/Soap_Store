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
    public partial class Purchases : Form
    {
        private DataClasses1DataContext db;
        Customer user;
        bool all_purc = true, price_purc = false, date_purc = false;
        decimal min_price, max_price;
        DateTime min_date, max_date;

        public Purchases(Customer User)
        {
            user = User;
            InitializeComponent();
            InitializeDataContext();
        }
        private void InitializeDataContext()
        {
            // Initialize your LINQ to SQL data context
            db = new DataClasses1DataContext();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            var home = new My_Account(user);
            home.Show();
            this.Hide();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {

        }

        

        private void all_purc_radio_CheckedChanged(object sender, EventArgs e)
        {
            all_purc = true;
            price_purc = false;
            date_purc = false;
        }
        private void price_purc_radio_CheckedChanged(object sender, EventArgs e)
        {
            all_purc = false;
            price_purc = true;
            date_purc = false;
        }

        private void date_purc_radio_CheckedChanged(object sender, EventArgs e)
        {
            all_purc = false;
            price_purc = false;
            date_purc = true;
        }
        private void min_price_picker_ValueChanged(object sender, EventArgs e)
        {
            if (price_purc)
            {
                min_price = min_price_picker.Value;

                // Ensure that max_price is greater than or equal to min_price
                if (max_price < min_price)
                {
                    max_price_picker.Value = min_price;
                    max_price = min_price;
                }
            }
        }

        private void max_price_picker_ValueChanged(object sender, EventArgs e)
        {
            if (price_purc)
            {
                max_price = max_price_picker.Value;

                // Ensure that max_price is greater than or equal to min_price
                if (max_price < min_price)
                {
                    min_price_picker.Value = max_price;
                    min_price = max_price;
                }
            }
        }

        private void min_date_picker_ValueChanged(object sender, EventArgs e)
        {
            if (date_purc)
            {
                min_date = min_date_picker.Value;

                // Ensure that max_date is greater than or equal to min_date
                if (max_date < min_date)
                {
                    max_date_picker.Value = min_date;
                    max_date = min_date;
                }
            }
        }

        private void max_date_picker_ValueChanged(object sender, EventArgs e)
        {
            if (date_purc)
            {
                max_date = max_date_picker.Value;

                // Ensure that max_date is greater than or equal to min_date
                if (max_date < min_date)
                {
                    min_date_picker.Value = max_date;
                    min_date = max_date;
                }
            }
        }
        private void list_invoice_btn_Click(object sender, EventArgs e)
        {
            int id = user.customer_id;
            List<Invoice> purchases;
            if (price_purc)
            {
                // Filter purchases by price range and customer_id
                purchases = db.Invoices
                    .Where(p => p.total_price >= min_price && p.total_price <= max_price && p.customer_id == user.customer_id)
                    .ToList();
            }
            else if (date_purc)
            {
                // Filter purchases by date range and customer_id
                purchases = db.Invoices
                    .Where(p => p.Date >= min_date && p.Date <= max_date && p.customer_id == user.customer_id)
                    .ToList();
            }
            else if (all_purc)
            {
                // Display all purchases for the current user
                purchases = db.Invoices
                    .Where(p => p.customer_id == user.customer_id)
                    .ToList();
            }
            else
            {
                purchases = null;
            }

            // Check if purchases is null or empty
            if (purchases != null && purchases.Any())
            {
                var display = new Display_Purchases(purchases, user);
                display.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No invoices available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }


}

