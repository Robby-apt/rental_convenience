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
    }
}
