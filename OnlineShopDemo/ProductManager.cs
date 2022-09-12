namespace OnlineShopDemo
{
    internal class ProductManager
    {
        private Dictionary<Product, int> stockLevel;

        public ProductManager()
        {
            this.stockLevel = new Dictionary<Product, int>()
            {
                { new Product("Computer", 10), 10 },
                { new Product("Mouse", 2), 10 },
            };

        }

        public int CheckStock(Product productToCheck)
        {
            return stockLevel[productToCheck];
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            foreach (Product product in this.stockLevel.Keys)
            {
                products.Add(product);
            }
            return products;
        }

        public void UpdateStock(Product productToUpdate, int newAmount)
        {
            stockLevel[productToUpdate] = newAmount;
        }
    }
}