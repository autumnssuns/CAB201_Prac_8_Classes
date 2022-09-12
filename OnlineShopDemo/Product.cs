namespace OnlineShopDemo
{
    public class Product
    {
        private int Id;

        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Id = 0;
            Name = name;
            Price = price;
        }
    }
}