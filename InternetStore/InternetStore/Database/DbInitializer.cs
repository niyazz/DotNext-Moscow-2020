using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetStore.Entities;
namespace InternetStore.Database
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;  
            }

            var products = new Product[]
            {
                new Product("Hair Dryer", 40),
                new Product("Fridge", 100),
                new Product("Cable", 5),
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

        }
    }
}
