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
    public partial class CustomerCart : Form
    {
        public CustomerCart()
        {
            InitializeComponent();
            // Wire up the event handler to the appropriate event
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
        }

        private string loggedInUsername;
        public void SetLoggedInUsername(string username)
        {
            loggedInUsername = username;
        }

        // Function to display Cart total
        private void DisplayCartTotal()
        {
            for(int i = 0; i < Program.CustomerRepo.Customers.Count; i++)
            {
                if(Program.CustomerRepo.Customers[i].Username == loggedInUsername)
                {
                    labelCartTotal.Text = $"Your cart total is: GBP {Program.CustomerRepo.Customers[i].GetCartTotal()}";
                    break;
                }
            } 
        }
        // Handle cell value change event
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Call the DisplayCartTotal() method to recalculate and display the updated total
            DisplayCartTotal();
        }

        // Bind appliances to cart grid
        private void BindAppliancesToCartGrid()
        {
            // Find the logged-in customer
            Customer loggedInCustomer = Program.CustomerRepo.Customers.FirstOrDefault(c => c.Username == loggedInUsername);

            if (loggedInCustomer != null)
            {
                // Provide data source for DataGridView
                dataGridView2.DataSource = loggedInCustomer.Cart;

                // Add button that removes from cart for each appliance
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "RemoveFromCart";
                buttonColumn.Text = "Remove from cart";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(buttonColumn);

                // Subscribe to CartUpdated event
                loggedInCustomer.CartUpdated += loggedInCustomer_CartUpdated;
            }
        }

        // CartUpdated event handler
        private void loggedInCustomer_CartUpdated(object sender, EventArgs e)
        {
            // Refresh the DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ((Customer)sender).Cart;
            // Redisplay the Cart total
            DisplayCartTotal();
        }


        // Handle cell click event
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["RemoveFromCart"].Index && e.RowIndex >= 0)
            {
                // Get the selected appliance from the DataGridView
                Appliance selectedAppliance = (Appliance)dataGridView2.Rows[e.RowIndex].DataBoundItem;

                // Find the logged-in customer
                Customer loggedInCustomer = Program.CustomerRepo.Customers.FirstOrDefault(c => c.Username == loggedInUsername);

                if (loggedInCustomer != null)
                {
                    // Remove the selected appliance from the cart of the logged-in customer
                    loggedInCustomer.DeleteFromCart(selectedAppliance);

                    // Refresh the DataGridView
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = loggedInCustomer.Cart;

                    // Redisplay the Cart total
                    DisplayCartTotal();
                }
            }
        }


        private void CustomerCart_Load(object sender, EventArgs e)
        {
            // Providing data source to DataGridView
            BindAppliancesToCartGrid();
            dataGridView2.CellClick += dataGridView2_CellClick;

            // Displaying the cart total
            DisplayCartTotal();
        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.SetLoggedInUsername(loggedInUsername);
            customerDashboard.Show();
            this.Hide();
        }
    }
}
