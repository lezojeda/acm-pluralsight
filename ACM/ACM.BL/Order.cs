using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public bool Validate()
        {
            return true;
        }

        public List<Order> RetrieveAllOrders()
        {
            return new List<Order>();
        }
    }
}
