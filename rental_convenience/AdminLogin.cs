using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_convenience
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminLoginToCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            // Check if username and password match admin credentials
            if (adminLoginUsername.Text != Program.admin.Username || adminLoginPassword.Text != Program.admin.Password)
            {
                MessageBox.Show("Kindly enter the right admin credentials");
                adminLoginUsername.Clear();
                adminLoginPassword.Clear();
            }
            else
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
        }
    }
}
