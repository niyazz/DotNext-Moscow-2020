using System.ComponentModel.DataAnnotations;
using Force.Ddd;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Core.Entities
{
    // JSON Serialization prevents encapsulation :(
    public class CartItem : HasIdBase
    {
        [HiddenInput]
        public override int Id { get; set; }
        
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        public string ProductName { get; set; } = default!;

        [Display(Name = "Category")]
        public string CategoryName { get; set; } = default!;

        [Display(Name = "Price")]
        public double Price { get; set; }
        
        [Display(Name = "Count")]
        public int Count { get; set; }
        
        public override string ToString() => $"{ProductName}: ${Price}";
    }
}