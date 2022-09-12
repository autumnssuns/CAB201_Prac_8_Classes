using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopDemo
{
    internal class Customer
    {
        private int ID;

        public string Username { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string DateOfBirth { get; set; }

        private ProductManager manager;

        public List<Order> listOfOrders;

        public Customer(string username, string phoneNumber, string password, 
            string email, string address, string dateOfBirth, ProductManager manager)
        {
            ID = 0;
            Username = username;
            PhoneNumber = phoneNumber;
            Password = password;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            this.manager = manager;
            listOfOrders = new List<Order>();
        }

        public void PlaceOrder(Product product, int quantity)
        {
            int currentStockLevel = manager.CheckStock(product);
            if (currentStockLevel >= quantity)
            {
                manager.UpdateStock(product, currentStockLevel - quantity);
                listOfOrders.Add(new Order(product, quantity));
            } else
            {
                Console.WriteLine("Out of stock");
            }
        }
    }
}
