﻿using System;
using System.ComponentModel.DataAnnotations;
using Force.Ddd;
using HightechAngular.Core.Entities;
using HightechAngular.Shop.Features.Index.GetSale;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Features.Index.GetBestsellers
{
    public class GetBestsellersListItem: HasIdBase
    {
        static GetBestsellersListItem()
        {
            TypeAdapterConfig<Product, GetSaleListItem>
                .NewConfig()
                .Map(dest => dest.Price, Product.DiscountedPriceExpression)
                .Map(dest => dest.DateCreatedName, src => src.DateCreated.ToString("d"));
        }

        [Display(Name = "Id")]
        public override int Id { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        
        [Display(Name = "Price")]
        public double Price { get; set; }
        
        [Display(Name = "Discount Percent")]
        public int DiscountPercent { get; set; }
        
        [Display(Name = "Date Created")]
        public string DateCreatedName { get; set; }
        
        [HiddenInput]
        public DateTime DateCreated { get; set; }
    }
}