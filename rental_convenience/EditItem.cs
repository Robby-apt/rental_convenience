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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }
        private Appliance currentAppliance;
        public void SetCurrentAppliance(Appliance appliance)
        {
            currentAppliance = appliance;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            if (editType.Text == "" || editBrand.Text == "" || editModel.Text == "" || editDimensions.Text == "" || editColour.Text == "" || editPowerConsumption.Text == "" || editMinRentTime.Text == "" || editMonthlyFee.Text == "")
            {
                MessageBox.Show("Kindly fill all the fields");
            }
            else
            {
                this.Hide();
                Program.admin.EditItem(currentAppliance, editType.Text, editBrand.Text, editModel.Text, editDimensions.Text, editColour.Text, editPowerConsumption.Text, Int32.Parse(editMinRentTime.Text), Decimal.Parse(editMonthlyFee.Text));
            }
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            editType.Text = currentAppliance.Type;
            editBrand.Text = currentAppliance.Brand;
            editModel.Text = currentAppliance.Model;
            editDimensions.Text = currentAppliance.Dimensions;
            editColour.Text = currentAppliance.Colour;
            editPowerConsumption.Text = currentAppliance.PowerConsumption;
            editMinRentTime.Text = currentAppliance.MinRentTime.ToString();
            editMonthlyFee.Text = currentAppliance.MonthlyFee.ToString();
        }
    }
}
