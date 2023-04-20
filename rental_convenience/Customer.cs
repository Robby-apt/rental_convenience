using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_convenience
{
    public class Customer: User
    {
        // Cart as an array of appliances
        public List<Appliance> Cart { get; set; }

        public Customer(string username, string password) : base(username, password)
        {
            Cart = new List<Appliance>();
        }

        public void AddToCart(Appliance appliance) {
            this.Cart.Add(appliance);
            MessageBox.Show("Added to cart");
        }
        public void DeleteFromCart(Appliance appliance) {
            for (int i = 0; i < this.Cart.Count; i++) {
                if(this.Cart[i].Model == appliance.Model)
                {
                    Cart.RemoveAt(i);
                }
            }
            MessageBox.Show("Deleted from cart");
        }
        public void GetCartTotal() {
            Console.WriteLine("Total is...");
        }
    }
}
