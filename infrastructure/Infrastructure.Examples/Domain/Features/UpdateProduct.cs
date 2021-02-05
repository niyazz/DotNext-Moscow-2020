using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Force.Cqrs;
using Force.Ddd;
using Infrastructure.Examples.Domain.Entities;

namespace Infrastructure.Examples.Domain.Features
{
    public class UpdateProduct: HasIdBase, ICommand
    {
        public static readonly Expression<Func<Product, UpdateProduct>> Map =
            x => new UpdateProduct
            {
                Id = x.Id,
                Name = x.Name,
                DiscountPercent = x.DiscountPercent,
                Price = x.Price
            };
        
        [Required, StringLength(255)]
        public string Name { get; set; }
        
        [Range(0, 1000000)]
        public double Price { get; set; }
        
        [Range(0, 100)]
        public int DiscountPercent { get; set; }
    }
}