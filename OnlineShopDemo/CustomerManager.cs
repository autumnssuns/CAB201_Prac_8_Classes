using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopDemo
{
    internal class CustomerManager
    {
        private List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer newCustomer)
        {
            customers.Add(newCustomer);
        }

        public void Delete(Customer customerToDelete)
        {
            customers.Remove(customerToDelete);
        }

        public Customer Login(string username, string password)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Username == username && customer.Password == password)
                {
                    return customer;
                }
            }
            Console.WriteLine("Username or password do not match");
            return null;
        }
    }
}
