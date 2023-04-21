using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_convenience
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password)
        {
        }

        public void AddItem(string type, string brand, string model, string dimensions, string colour, string powerConsumption, int minRentTime, decimal monthlyFee)
        {
            Program.ApplianceRepo.AddAppliance(type, brand, model, dimensions, colour, powerConsumption, minRentTime, monthlyFee);
            Console.WriteLine("Item added");
        }
        public void EditItem() {
            Console.WriteLine("Item edited");
        }
        public void DeleteItem(Appliance appliance) {
            for (int i = 0; i < Program.ApplianceRepo.Appliances.Count; i++)
            {
                if (Program.ApplianceRepo.Appliances[i].Model == appliance.Model)
                {
                    Program.ApplianceRepo.Appliances.RemoveAt(i);
                    OnInventoryUpdated();
                    break;
                }
            }
            MessageBox.Show("Deleted from cart");
        }

        // Event for updating inventory
        public event EventHandler InventoryUpdated;
        protected virtual void OnInventoryUpdated()
        {
            InventoryUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
