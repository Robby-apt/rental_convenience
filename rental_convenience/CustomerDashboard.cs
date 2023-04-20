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

        private void BindAppliancesToGrid()
        {
            // Provide data source for DataGridView
            dataGridView1.DataSource = Program.ApplianceRepo.Appliances;

            // Add button that adds to cart for each appliance
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "AddToCart";
            buttonColumn.Text = "Add to cart";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["AddToCart"].Index && e.RowIndex >= 0)
            {
                // Get the selected appliance from the DataGridView
                Appliance selectedAppliance = (Appliance)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Find the logged-in customer
                Customer loggedInCustomer = Program.CustomerRepo.Customers.FirstOrDefault(c => c.Username == loggedInUsername);

                if (loggedInCustomer != null)
                {
                    // Add the selected appliance to the cart of the logged-in customer
                    loggedInCustomer.AddToCart(selectedAppliance);
                }
            }
        }


        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            customerGreeting.Text = $"Hello {loggedInUsername}";
            BindAppliancesToGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void toCartBtn_Click(object sender, EventArgs e)
        {
            CustomerCart customerCart = new CustomerCart();
            customerCart.SetLoggedInUsername(loggedInUsername);
            customerCart.Show();
            this.Hide();
        }
    }
}
