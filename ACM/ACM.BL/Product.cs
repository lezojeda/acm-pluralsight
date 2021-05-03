using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal CurrentPrice { get; set; }

        public override bool Validate()
        {
            return Description.Length < 100 && !string.IsNullOrWhiteSpace(ProductName);
        }

        public List<Product> RetrieveAllProducts()
        {
            return new List<Product>();
        }
    }
}
