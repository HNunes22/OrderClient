namespace OrderClient.Entities
{
    internal class OrderItem
    {
        public int QuantityItem {  get; set; }
        public double PriceItem { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantityItem, double priceItem, Product product)
        {
            QuantityItem = quantityItem;
            PriceItem = priceItem;
            Product = product;
        }
    }
}
