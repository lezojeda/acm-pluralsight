using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderRepository
    // Uses Order class (type of relationship "Collaboration")
    {
        public List<Address> AddressList { get; set; }

        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
