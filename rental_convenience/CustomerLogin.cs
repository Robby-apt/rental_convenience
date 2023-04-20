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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }
        // keep track of logged in user
        public string loggedUsername { get; private set; }

        private void loginToAdminPortalBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void loginToSignupBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void customerLoginBtn_Click(object sender, EventArgs e)
        {
            if(loginUsername.Text == "" || loginPassword.Text == "")
            {
                MessageBox.Show("Kindly fill all the fields");
            }
            else
            {
                bool foundMatch = false;

                for (int i = 0; i < Program.CustomerRepo.Customers.Count; i++) {
                    /*foreach (Customer customer in Program.CustomerRepo.Customers)
                    {*/
                    Customer customer = Program.CustomerRepo.Customers[i];

                    if (customer.Username != loginUsername.Text || customer.Password != loginPassword.Text)
                    {
                        continue;
                    }
                    else
                    {
                        foundMatch = true;
                        // Keep track of logged username
                        loggedUsername = customer.Username;
                        // Redirect to dashboard
                        CustomerDashboard customerDashboard = new CustomerDashboard();
                        customerDashboard.SetLoggedInUsername(loggedUsername);
                        customerDashboard.Show();
                        this.Hide();
                        break;
                    }
                }
                if (foundMatch == false)
                {
                    MessageBox.Show("The username or password does not exist");
                    loginUsername.Clear();
                    loginPassword.Clear();
                }
            }
        }
    }
}
