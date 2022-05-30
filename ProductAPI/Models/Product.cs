using System;

namespace ProductAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string productName, string description, string category, decimal price)
        {
            Id = id;
            ProductName = productName;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}

