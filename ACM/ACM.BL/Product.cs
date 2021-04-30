using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {
        public string ProductName { get; set; }

        public string Description { get; set; }

        public double CurrentPrice { get; set; }

        public bool Validate()
        {
            return Description.Length < 100 && !string.IsNullOrWhiteSpace(ProductName);
        }

        public Product Retrieve(string productId)
        {
            return new Product();
        }

        public List<Product> RetrieveAllProducts()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
