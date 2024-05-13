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
    public partial class Cart : Form
    {
        private DataClasses1DataContext db;
        Customer user;
        public Cart(Customer User)
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            var dash = new Shop(user);
            dash.Show();
            this.Hide();
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            var bal = new Balance(user);
            bal.Show();
            this.Hide();

        }

        private void total_label_Click(object sender, EventArgs e)
        {


        }

        private void Cart_Load(object sender, EventArgs e)
        {
            total_label.Text = user.balance.ToString();
        }
    }
}
