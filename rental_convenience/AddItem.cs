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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void cancelAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addToInventoryBtn_Click(object sender, EventArgs e)
        {
            if(addType.Text == "" || addBrand.Text == "" || addModel.Text == "" || addDimensions.Text == "" || addColour.Text == "" || addPowerConsumption.Text == "" || addMinRentTime.Text == "" || addMonthlyFee.Text == "")
            {
                MessageBox.Show("Kindly fill all the fields");
            }
            else
            {
                Program.admin.AddItem(addType.Text, addBrand.Text, addModel.Text, addDimensions.Text, addColour.Text, addPowerConsumption.Text, Int32.Parse(addMinRentTime.Text), Decimal.Parse(addMonthlyFee.Text));
                Application.OpenForms.OfType<AdminDashboard>().FirstOrDefault().refreshDataGrid();
                this.Hide();
            }
        }
    }
}
