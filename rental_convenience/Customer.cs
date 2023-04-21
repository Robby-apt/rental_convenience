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
        // Event for updating cart
        public event EventHandler CartUpdated;

        protected virtual void OnCartUpdated()
        {
            CartUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void AddToCart(Appliance appliance) {
            this.Cart.Add(appliance);
            MessageBox.Show("Added to cart");
        }
        public void DeleteFromCart(Appliance appliance) {
            for (int i = 0; i < this.Cart.Count; i++) {
                if(this.Cart[i].Model == appliance.Model)
                {
                    this.Cart.RemoveAt(i);
                    OnCartUpdated();
                    break;
                }
            }
            MessageBox.Show("Deleted from cart");
        }

        public decimal GetCartTotal()
        {
            decimal total = 0;

            foreach (Appliance appliance in this.Cart)
            {
                int rentingPeriod = appliance.GetMinimumRentingPeriod();
                decimal rentingFee = appliance.MonthlyFee;
                decimal subtotal = rentingFee * rentingPeriod;
                total += subtotal;
            }

            return total;
        }
    }
}
