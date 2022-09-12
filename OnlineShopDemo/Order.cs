namespace OnlineShopDemo
{
    internal class Order
    {
        public Product OrderProduct { get; set; }

        public int Quantity { get; set; }

        public Order(Product product, int quantity)
        {
            OrderProduct = product;
            Quantity = quantity;
        }
    }
}