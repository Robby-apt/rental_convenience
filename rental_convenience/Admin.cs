using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_convenience
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password)
        {
        }

        public void AddItem(string type, string brand, string model, string dimensions, string colour, string powerConsumption, string minRentTime, decimal monthlyFee)
        {
            Program.ApplianceRepo.AddAppliance(type, brand, model, dimensions, colour, powerConsumption, minRentTime, monthlyFee);
            Console.WriteLine("Item added");
        }
        public void EditItem() {
            Console.WriteLine("Item edited");
        }
        public void DeleteItem() {
            Console.WriteLine("Item deleted");
        }
    }
}
