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
    public partial class Balance : Form
    {
        private DataClasses1DataContext db;
        Customer user;
        bool custom = false;
        decimal payment_amount;

        public Balance(Customer User)
        {
            InitializeComponent();
            user = User;
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

        private void Balance_Load(object sender, EventArgs e)
        {
            // Display user's current balance
            display_bal_label.Text = user.balance.ToString();
        }

        private void other_btn_CheckedChanged(object sender, EventArgs e)
        {
            custom = true;
            UpdatePaymentAmount();
        }

        private void bal_btn_CheckedChanged(object sender, EventArgs e)
        {
            custom = false;
            UpdatePaymentAmount();
        }

        private void UpdatePaymentAmount()
        {
            if (custom)
            {
                payment_amount = amount_picker.Value;
            }
            else
            {
                payment_amount = user.balance ?? 0;
            }
        }

        private void amount_picker_ValueChanged(object sender, EventArgs e)
        {
            if (custom)
            {
                payment_amount = amount_picker.Value;
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            user.balance -= payment_amount;
            decimal? new_bal = user.balance ?? 0;
            MessageBox.Show($"Payment of {payment_amount} confirmed!\n Your current balance is {new_bal}.",
                "Payment Confirmed", MessageBoxButtons.OK);
        }
    }
}
