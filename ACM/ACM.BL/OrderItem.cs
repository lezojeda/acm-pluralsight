using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Product product;

        public int Quantity { get; set; };

        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve(string orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }
    }
}
