using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_convenience
{
    public class Appliance
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Dimensions { get; set; }
        public string Colour { get; set; }
        public string PowerConsumption { get; set; }
        public string MinRentTime { get; set; }
        public decimal MonthlyFee { get; set; }

        // Constructor

        public Appliance(string type, string brand, string model, string dimensions, string colour, string powerConsumption, string minRentTime, decimal monthlyFee)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Dimensions = dimensions;
            Colour = colour;
            PowerConsumption = powerConsumption;
            MinRentTime = minRentTime;
            MonthlyFee = monthlyFee;
        }

        // Add a method to return the minimum renting period for each type of appliance
        public int GetMinimumRentingPeriod()
        {
            switch (this.Type)
            {
                case "TV":
                    return 1;
                case "Microwave":
                    return 2;
                case "Dishwasher":
                    return 3;
                case "Washing machine":
                    return 4;
                case "Fridge":
                    return 5;
                default:
                    return 0;
            }
        }
    }
}
