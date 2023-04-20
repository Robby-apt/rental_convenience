using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// use system regex
using System.Text.RegularExpressions;

namespace rental_convenience
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        // function to check for special characters in an input
        private static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        // function to check if password meets criteria
        private static bool isPasswordValid(string password)
        {
            /*CRITERIA
             * Has min length of 8 and max of 16
             * Has atleast one uppercase and one lowercase letter
             */
            if (password.Length < 8 || password.Length > 16) { return false; }
            else if (!Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]")) {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void regSignupBtn_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if(regUsername.Text == "" || regPassword.Text == "" || regConfirm.Text == "")
            {
                MessageBox.Show("Kindly fill all the fields");
            }
            // Check if the two password fields match
            else if (regPassword.Text != regConfirm.Text)
            {
                MessageBox.Show("Kindly ensure the passwords match");
                regPassword.Clear();
                regConfirm.Clear();
            }
            else if (hasSpecialChar(regUsername.Text) || !isPasswordValid(regPassword.Text))
            {
                MessageBox.Show("Kindly ensure your username contains only letters and numbers and your password is in the range of 8 to 16 characters long and has atleast one uppercase and one lowercase letter");
                regPassword.Clear();
                regConfirm.Clear();
            }
            else
            {
                // If all conditons are met
                string username = regUsername.Text;
                string password = regPassword.Text;
                // Add new customer to list of customers
                Program.CustomerRepo.AddCustomer(username, password);

                // Redirect to customer login
                CustomerLogin customerLogin = new CustomerLogin();
                customerLogin.Show();
                this.Hide();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void regToLoginBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void regToAdminPortalBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
