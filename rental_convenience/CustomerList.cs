using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_convenience
{
    public class CustomerList
    {
        public List<Customer> Customers { get; set; }

        public CustomerList()
        {
            Customers = new List<Customer>();
        }

        public void AddCustomer(string username, string password)
        {
            //Customers.Add(new Customer {Username = username,Password = password });
            Customers.Add(new Customer(username, password));
        }
    }
}
