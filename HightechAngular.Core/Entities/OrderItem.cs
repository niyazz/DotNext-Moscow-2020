using System;
using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using IntEntityBase = Infrastructure.Ddd.Domain.IntEntityBase;

namespace HightechAngular.Core.Entities
{
    public class OrderItem: IntEntityBase
    {
        [UsedImplicitly]
        protected OrderItem()
        {
        }

        internal OrderItem(Order order, CartItem cartItem)
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            Order = order;
            Count = cartItem.Count;
            Name = cartItem.ProductName;
            Price = cartItem.Price;
            ProductId = cartItem.ProductId;
        }
        
        [Required]
        public string Name { get; set; } = default!;

        public virtual Order Order { get; set; } = default!;

        public double Price { get; set; } 
        
        [Obsolete]
        public int DiscountPercent { get; set; }
        
        public int Count { get; set; }
        
        public int ProductId { get; set; }
    }
}