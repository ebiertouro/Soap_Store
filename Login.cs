using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SemesterProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string name, password;

        private void username_input_TextChanged(object sender, EventArgs e)
        {
            name = name_input.Text;
        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {
            password = password_input.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer user = CheckUsernameAndPasswordAndReturnUser(name, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Login successful, open new form or perform other actions
                // For example:
                var home = new My_Account(user);
                home.Show();
                this.Hide();
            }
        }

        private Customer CheckUsernameAndPasswordAndReturnUser(string username, string password)
        {
            using (var db = new DataClasses1DataContext())
            {
                Customer user = db.Customers.FirstOrDefault(u => u.name == name && u.password == password);
                return user;
            }
        }
    }
}
