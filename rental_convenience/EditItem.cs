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
                //Program.admin.EditItem(()sender,editType.Text, editBrand.Text, editModel.Text, editDimensions.Text, editColour.Text, editPowerConsumption.Text, Int32.Parse(editMinRentTime.Text), Decimal.Parse(editMonthlyFee.Text))
            }
        }

        private void EditItem_Load(object sender, EventArgs e)
        {

        }
    }
}
