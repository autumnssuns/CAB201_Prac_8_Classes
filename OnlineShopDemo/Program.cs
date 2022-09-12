namespace OnlineShopDemo
{
    class Program
    {


        public static void Main(string[] args)
        {
            string input = "";
            const string EXIT = "3";
            const string LOGIN = "2", SIGNUP = "1";
            CustomerManager manager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            Customer currentCustomer;
            do
            {
                Console.WriteLine(@"Select an option
1. Signup
2. Login
3. Quit the program");
                input = Console.ReadLine();
                switch (input)
                {
                    case SIGNUP:
                        string username = Console.ReadLine();
                        string password = Console.ReadLine();
                        string phoneNumber = Console.ReadLine();
                        string email = Console.ReadLine();
                        string address= Console.ReadLine();
                        string dob = Console.ReadLine();
                        Customer newCustomer = new Customer(username, phoneNumber, password, email, address, dob, productManager);
                        manager.Add(newCustomer);
                        break;

                    case LOGIN:
                        username = Console.ReadLine();
                        password = Console.ReadLine();
                        currentCustomer = manager.Login(username, password);
                        if (currentCustomer != null){
                            // Another menu
                            ShowCustomerMenu(currentCustomer, manager, productManager);
                        }
                        break;
                    case EXIT:
                        Console.WriteLine("Exiting the program");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (input != EXIT);
        }

        static void ShowCustomerMenu(Customer currentCustomer, CustomerManager manager, ProductManager productManager)
        {
            string input = "";
            const string BROWSE_PRODUCT = "1", ORDER_PRODUCT = "2", LOGOUT = "3";
            do
            {
                Console.WriteLine(@"Select an option
1. Browse Product
2. Order
3. Log out");
                input = Console.ReadLine();
                switch (input)
                {

                    case BROWSE_PRODUCT:
                        List<Product> products = productManager.GetProducts();
                        products.ForEach(p => Console.WriteLine(p.Name));
                        break;
                    case ORDER_PRODUCT:
                        products = productManager.GetProducts();
                        string productName = Console.ReadLine();
                        Product productToOrder = null;
                        foreach (Product product in products)
                        {
                            if (product.Name == productName)
                                productToOrder = product;
                        }
                        if (productToOrder != null)
                        {
                            int quantity = int.Parse(Console.ReadLine());
                            currentCustomer.PlaceOrder(productToOrder, quantity);
                        }
                        break;
                    case LOGOUT:
                        Console.WriteLine("Log out");
                        break;
                }
            } while (input != LOGOUT);
        }
    }
}