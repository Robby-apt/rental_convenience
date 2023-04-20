using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_convenience
{
    public class ApplianceList
    {
        public List<Appliance> Appliances { get; set; }

        public ApplianceList()
        {
            Appliances = new List<Appliance>();
        }

        public void AddAppliance(string type, string brand, string model, string dimensions, string colour, string powerConsumption, string minRentTime, decimal monthlyFee)
        {
            //Customers.Add(new Customer {Username = username,Password = password });
            Appliances.Add(new Appliance(type, brand, model, dimensions, colour, powerConsumption, minRentTime, monthlyFee));
        }
    }
}
