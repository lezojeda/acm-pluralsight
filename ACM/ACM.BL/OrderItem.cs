namespace ACM.BL
{
    public class OrderItem
    {
        public Product product;

        public int Quantity { get; set; };

        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public OrderItem Retrieve(string orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
    }
}
