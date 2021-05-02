using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public string OrderDate { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve(string orderId)
        {
            return new Order();
        }

        public List<Order> RetrieveAllOrders()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
