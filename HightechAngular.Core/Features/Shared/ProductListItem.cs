using System;
using System.ComponentModel.DataAnnotations;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Core.Features.Shared
{
    public class ProductListItem: HasIdBase
    {
        static ProductListItem()
        {
            TypeAdapterConfig<Product, ProductListItem>
                .NewConfig()
                .Map(dest => dest.DateCreatedName, src => src.DateCreated.ToString("d"));
        }

        [Display(Name = "Id")]
        public override int Id { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; } = default!;

        [Display(Name = "Category")]
        public string CategoryName { get; set; } = default!;

        [Display(Name = "Price")]
        public double Price { get; set; }
        
        [Display(Name = "Discount Percent")]
        public int DiscountPercent { get; set; }
        
        [Display(Name = "Date Created")]
        public string DateCreatedName { get; set; } = default!;

        [HiddenInput]
        public DateTime DateCreated { get; set; }

        [HiddenInput]
        public int CategoryId { get; set; }

        public override string ToString() => DiscountPercent > 0
            ? $"{Name} ${Price} Sale: ${DiscountPercent}%!"
            : $"{Name} ${Price}";
    }
}