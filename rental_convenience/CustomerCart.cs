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
        }

        private string loggedInUsername;
        public void SetLoggedInUsername(string username)
        {
            loggedInUsername = username;
        }
        /*private void BindAppliancesToGrid()
        {
            // Get logged in customer object
            for(int i = 0; i < Program.CustomerRepo.Customers.Count; i++)
            {
                if(Program.CustomerRepo.Customers[i].Username == loggedInUsername)
                {
                    // Provide data source for Data grid view
                    dataGridView2.DataSource = Program.CustomerRepo.Customers[i].Cart;

                    // Add button that adds to cart for each appliance
                    foreach (Appliance appliance in Program.CustomerRepo.Customers[i].Cart)
                    {
                        Button button = new Button();
                        button.Text = "Remove from cart";
                        button.Click += (sender, e) =>
                        {
                            for (int j = 0; j < Program.CustomerRepo.Customers[i].Cart.Count; j++)
                            {
                                Program.CustomerRepo.Customers[i].DeleteFromCart(appliance);
                                break;
                            }
                        };
                        dataGridView2.Controls.Add(button);
                    }
                }
                break;
            }
        }*/
        /*private void BindAppliancesToCartGrid()
        {
            // Provide data source for DataGridView
            // Get logged in customer object
            for (int i = 0; i < Program.CustomerRepo.Customers.Count; i++)
            {
                if (Program.CustomerRepo.Customers[i].Username == loggedInUsername)
                {
                    // Provide data source for Data grid view
                    dataGridView2.DataSource = Program.CustomerRepo.Customers[i].Cart;
                    // Add button that adds to cart for each appliance
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.Name = "RemoveFromCart";
                    buttonColumn.Text = "Remove from cart";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView2.Columns.Add(buttonColumn);
                    break; // Move the break statement here
                }
            }
        }


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
                    // Add the selected appliance to the cart of the logged-in customer
                    loggedInCustomer.DeleteFromCart(selectedAppliance);
                }
            }
        }*/

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
            }
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
                }
            }
        }


        private void CustomerCart_Load(object sender, EventArgs e)
        {
            BindAppliancesToCartGrid();
            dataGridView2.CellClick += dataGridView2_CellClick;
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
