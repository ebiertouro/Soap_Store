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
    public partial class My_Account : Form
    {
        Customer user;
        public My_Account(Customer User)
        {
            InitializeComponent();
            user = User;
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            var dashboard = new Shop(user);
            dashboard.Show();
            this.Hide();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            var cart = new Cart(user);
            cart.Show();
            this.Hide();
        }

        private void purchases_btn_Click(object sender, EventArgs e)
        {
            var purchases = new Purchases(user);
            purchases.Show();
            this.Hide();
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
            var balance = new Balance(user);
            balance.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms logout
            if (result == DialogResult.Yes)
            {

                // Show the login form (assuming it's named LoginForm)
                Login loginForm = new Login();
                loginForm.Show();

                // Close the current form
                this.Close();
            }
        }

    }
}
