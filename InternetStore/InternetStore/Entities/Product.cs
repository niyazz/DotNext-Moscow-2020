using System;
using System.Collections.Generic;

namespace InternetStore.Entities
{
    public class Product
    {
        public Product()
        {
            OrderToProduct = new List<OrderToProduct>();
        }
        public Product(string name, double price)
        {
            this.Id = new Guid();
            this.Name = name;
            this.Price = price;
            this.CreatedAt = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderToProduct> OrderToProduct { get; set; }
    } 
}
