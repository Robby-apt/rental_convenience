using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_convenience
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static CustomerList CustomerRepo { get; set; }
        //Hard code Admin credentials
        public static Admin admin = new Admin("rentalConvenience", "rentalConvenience");
        // List of appliances
        public static ApplianceList ApplianceRepo { get; set; }

        [STAThread]
        static void Main()
        {
            // Initialize CustomerList to storeregistered users
            Program.CustomerRepo = new CustomerList();

            // Initialize CustomerList to storeregistered users
            Program.ApplianceRepo = new ApplianceList();

            // Adding all the appliances
            // Cretating TVs
            Program.ApplianceRepo.AddAppliance("TV", "Samsung", "QN65Q90TAFXZA", "145 cm x 83.1 cm x 3.6 cm", "Black", "0.5kWh per hour", 1, 50);
            Program.ApplianceRepo.AddAppliance("TV", "LG", "OLED55C1PUB", "122.7 cm x 73.9 cm x 4.6 cm", "White", "0.5kWh per hour", 1, 150);
            Program.ApplianceRepo.AddAppliance("TV", "Sony", "XBR65X900H", "145 cm x 83.6 cm x 7.4 cm", "Black", "0.5kWh per hour", 1, 100);
            Program.ApplianceRepo.AddAppliance("TV", "TCL", "55R635", "122.7 cm x 71.4 cm x 7.1 cm", "White", "0.5kWh per hour", 1, 50);
            Program.ApplianceRepo.AddAppliance("TV", "Vizio", "OLED65-H1", "144.8 cm x 83.1 cm x 5.8 cm", "Black", "0.5kWh per hour", 1, 100);
            Program.ApplianceRepo.AddAppliance("TV", "Samsung", "UN50TU8000FXZA", "112.8 cm x 65 cm x 6.1 cm", "White", "0.5kWh per hour", 1, 150);
            Program.ApplianceRepo.AddAppliance("TV", "LG", "NanoCell 85 Series", "167.4 cm x 95.8 cm x 7.1 cm", "Black", "0.5kWh per hour", 1, 50);
            Program.ApplianceRepo.AddAppliance("TV", "Sony", "KD55X80J", "123.4 cm x 71.6 cm x 7.4 cm", "White", "0.5kWh per hour", 1, 50);
            Program.ApplianceRepo.AddAppliance("TV", "TCL", "65S435", "145.5 cm x 84.6 cm x 7.6 cm", "Black", "0.5kWh per hour", 1, 100);
            Program.ApplianceRepo.AddAppliance("TV", "Hisense", "55H8G", "122.9 cm x 71.1 cm x 7.9 cm", "White", "0.5kWh per hour", 1, 150);

            // Cretating Microwaves
            Program.ApplianceRepo.AddAppliance("Microwave", "Panasonic", "NN-SN936B", "60.7 cm x 49.3 cm x 37.8 cm", "Black", "0.5kWh per hour", 2, 50);
            Program.ApplianceRepo.AddAppliance("Microwave", "Toshiba", "EM131A5C-BS", "52.1 cm x 43.4 cm x 32.5 cm", "White", "0.5kWh per hour", 2, 150);
            Program.ApplianceRepo.AddAppliance("Microwave", "GE", "JES1072SHSS", "43.9 cm x 33 cm x 25.9 cm", "Black", "0.5kWh per hour", 2, 100);
            Program.ApplianceRepo.AddAppliance("Microwave", "LG", "LMV2031ST", "75.9 cm x 40.4 cm x 41.7 cm", "White", "0.5kWh per hour", 2, 50);
            Program.ApplianceRepo.AddAppliance("Microwave", "Samsung", "MS14K6000AS", "55.4 cm x 47.2 cm x 31.2 cm", "Black", "0.5kWh per hour", 2, 100);
            Program.ApplianceRepo.AddAppliance("Microwave", "Whirlpool", "WMH31017HZ", "75.9 cm x 41.4 cm x 43.4 cm", "White", "0.5kWh per hour", 2, 150);
            Program.ApplianceRepo.AddAppliance("Microwave", "Sharp", "SMD2470AS", "60.7 cm x 58.7 cm x 40.4 cm", "Black", "0.5kWh per hour", 2, 50);
            Program.ApplianceRepo.AddAppliance("Microwave", "Bosch", "HMB5051", "60.7 cm x 59.4 cm x 35.6 cm", "White", "0.5kWh per hour", 2, 50);
            Program.ApplianceRepo.AddAppliance("Microwave", "Kenmore", "70913", "57.9 cm x 50 cm x 33.5 cm", "Black", "0.5kWh per hour", 2, 100);
            Program.ApplianceRepo.AddAppliance("Microwave", "Frigidaire", "FFMV1846VS", "75.9 cm x 40.1 cm x 41.7 cm", "White", "0.5kWh per hour", 2, 150);

            // Cretating Dishwashers
            Program.ApplianceRepo.AddAppliance("Dishwasher", "Bosch", "SHPM88Z75N 800 Series", "59.9 cm x 86.1 cm x 60.5 cm", "Black", "0.5kWh per hour", 3, 200);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "LG", "LDP6797BD", "60.5 cm x 85.3 cm x 62.5 cm", "White", "0.5kWh per hour", 3, 250);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "KitchenAid", "KDPM604KPS", "60.7 cm x 85.1 cm x 60.5 cm", "Black", "0.5kWh per hour", 3, 200);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "Samsung", "DW80R9950US", "61 cm x 86.1 cm x 62.7 cm", "White", "0.5kWh per hour", 3, 250);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "Whirlpool", "WDTA50SAKZ", "60.7 cm x 87.6 cm x 62.2 cm", "Black", "0.5kWh per hour", 3, 200);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "Frigidaire", "FGIP2468UF", "61 cm x 86.1 cm x 61.7 cm", "White", "0.5kWh per hour", 3, 250);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "Maytag", "MDB8959SKZ", "60.5 cm x 85.1 cm x 62.2 cm", "Black", "0.5kWh per hour", 3, 250);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "GE", "GDT665SGNWW", "60.5 cm x 86.4 cm x 61 cm", "White", "0.5kWh per hour", 3, 200);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "LG", "LDF5545ST", "60.5 cm x 85.3 cm x 62.5 cm", "Black", "0.5kWh per hour", 3, 100);
            Program.ApplianceRepo.AddAppliance("Dishwasher", "KitchenAid", "KDTM604KPS", "60.5 cm x 87.6 cm x 62.5 cm", "White", "0.5kWh per hour", 3, 250);

            // Cretating Washing machines
            Program.ApplianceRepo.AddAppliance("Washing machine", "Samsung", "WF45R6300AV", "68.6 cm x 98.3 cm x 79.8 cm", "Black", "0.5kWh per hour", 4, 50);
            Program.ApplianceRepo.AddAppliance("Washing machine", "LG", "WM3700HWA", "68.6 cm x 99.1 cm x 76.7 cm", "White", "0.5kWh per hour", 4, 150);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Whirlpool", "WTW5000DW", "69.9 cm x 106.7 cm x 71.1 cm", "Black", "0.5kWh per hour", 4, 100);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Maytag", "MVWB865GW", "70.9 cm x 109.2 cm x 71.1 cm", "White", "0.5kWh per hour", 4, 50);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Bosch", "WAW285H2UC", "59.7 cm x 84.3 cm x 63.5 cm", "Black", "0.5kWh per hour", 4, 100);
            Program.ApplianceRepo.AddAppliance("Washing machine", "GE", "GTW465ASNWW", "68.6 cm x 111.8 cm x 68.6 cm", "White", "0.5kWh per hour", 4, 150);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Electrolux", "EFLS627UIW", "68.6 cm x 96.5 cm x 80 cm", "Black", "0.5kWh per hour", 4, 50);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Kenmore", "41302", "68.6 cm x 98.3 cm x 80.8 cm", "White", "0.5kWh per hour", 4, 50);
            Program.ApplianceRepo.AddAppliance("Washing machine", "LG", "WT7200CW", "68.6 cm x 113 cm x 72.1 cm", "Black", "0.5kWh per hour", 4, 100);
            Program.ApplianceRepo.AddAppliance("Washing machine", "Speed Queen", "TR7000WN", "65 cm x 108.7 cm x 71.1 cm", "White", "0.5kWh per hour", 4, 150);

            // Cretating Fridges
            Program.ApplianceRepo.AddAppliance("Fridge", "LG", "LFXS28968S", "90.9 cm x 173.7 cm x 91.7 cm", "Black", "0.5kWh per hour", 5, 50);
            Program.ApplianceRepo.AddAppliance("Fridge", "Samsung", "RF28R7351SG", "90.7 cm x 177.8 cm x 90.4 cm", "White", "0.5kWh per hour", 5, 150);
            Program.ApplianceRepo.AddAppliance("Fridge", "Whirlpool", "WRF535SWHZ", "90.4 cm x 178.1 cm x 90.4 cm", "Black", "0.5kWh per hour", 5, 100);
            Program.ApplianceRepo.AddAppliance("Fridge", "Frigidaire", "FFSS2615TS", "91.4 cm x 175.3 cm x 81.3 cm", "White", "0.5kWh per hour", 5, 50);
            Program.ApplianceRepo.AddAppliance("Fridge", "KitchenAid", "KRFF507HPS", "91.4 cm x 178.1 cm x 92.9 cm", "Black", "0.5kWh per hour", 5, 100);
            Program.ApplianceRepo.AddAppliance("Fridge", "GE", "GNE27JSMSS", "90.9 cm x 177.5 cm x 90.7 cm", "White", "0.5kWh per hour", 5, 150);
            Program.ApplianceRepo.AddAppliance("Fridge", "LG", "LSXS26326S", "91.2 cm x 178.4 cm x 90.9 cm", "Black", "0.5kWh per hour", 5, 50);
            Program.ApplianceRepo.AddAppliance("Fridge", "Samsung", "RS25J500DSR", "90.9 cm x 177.5 cm x 91.9 cm", "White", "0.5kWh per hour", 5, 50);
            Program.ApplianceRepo.AddAppliance("Fridge", "Maytag", "MFI2570FEZ", "90.4 cm x 177.5 cm x 90.4 cm", "Black", "0.5kWh per hour", 5, 100);
            Program.ApplianceRepo.AddAppliance("Fridge", "Whirlpool", "WRS588FIHV", "91.4 cm x 175.3 cm x 85.1 cm", "White", "0.5kWh per hour", 5, 150);


            // No code beyond here
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
            // No code beyond here
        }
    }
}
