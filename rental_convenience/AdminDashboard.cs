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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Inventory Updated event handler
        private void inventoryUpdated(object sender, EventArgs e)
        {
            // Refresh the DataGridView
            adminGridView.DataSource = null;
            adminGridView.DataSource = Program.ApplianceRepo.Appliances;
        }
        // refresh the data grid
        public void refreshDataGrid()
        {
            adminGridView.DataSource = null;
            adminGridView.DataSource = Program.ApplianceRepo.Appliances;
        }

        // Provide data source for the data grid view
        private void BindAppliancesToGrid()
        {
            // Provide data source for DataGridView
            adminGridView.DataSource = Program.ApplianceRepo.Appliances;

            // Add button to edit each appliance
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditItem";
            editButtonColumn.Text = "Edit item";
            editButtonColumn.UseColumnTextForButtonValue = true;
            adminGridView.Columns.Add(editButtonColumn);

            // Add button to delete each appliance
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteItem";
            deleteButtonColumn.Text = "Delete item";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            adminGridView.Columns.Add(deleteButtonColumn);

            // Subscribe to inventory updated event
            Program.admin.InventoryUpdated += inventoryUpdated;
        }

        // Assigning functions to the buttons added to columns
        private void adminGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == adminGridView.Columns["EditItem"].Index && e.RowIndex >= 0)
            {
                // Get the selected appliance from the DataGridView
                Appliance selectedAppliance = (Appliance)adminGridView.Rows[e.RowIndex].DataBoundItem;
                // Display edit item form
                //EditItem editItem = new EditItem();
                //editItem.Show();
                // Code to edit appliance
            }else if (e.ColumnIndex == adminGridView.Columns["DeleteItem"].Index && e.RowIndex >= 0)
            {
                // Get the selected appliance from the DataGridView
                Appliance selectedAppliance = (Appliance)adminGridView.Rows[e.RowIndex].DataBoundItem;
                // Code to delete appliance
                Program.admin.DeleteItem(selectedAppliance);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            BindAppliancesToGrid();
            adminGridView.CellClick += adminGridView_CellClick;
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
