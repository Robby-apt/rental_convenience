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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private string loggedInUsername;
        public void SetLoggedInUsername(string username)
        {
            loggedInUsername = username;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            customerGreeting.Text = $"Hello {loggedInUsername}";
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }
    }
}
