using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Force.Ddd;
using Force.Ddd.DomainEvents;
using Infrastructure.Ddd.Domain.State;

namespace HightechAngular.Core.Entities
{
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public partial class Order : HasIdBase
    {
        public static readonly OrderSpecs Specs = new OrderSpecs();

        protected Order()
        {
        }

        public Order(Cart cart)
        {
            User = cart.User ?? throw new InvalidOperationException("User must be authenticated");
            
            _orderItems = cart
                .CartItems
                .Select(x => new OrderItem(this, x)
                {
                    Order = this,
                    Count = x.Count,
                    Name = x.ProductName,
                    Price = x.Price
                })
                .ToList();

            Total = _orderItems.Select(x => x.Price).Sum();
            Status = OrderStatus.New;
        }
        

        [Required]
        public virtual User User { get; protected set; } = default!;

        public DateTime Created { get; protected set; } = DateTime.UtcNow;
        
        public DateTime Updated { get; protected set; }
        
        private List<OrderItem> _orderItems = new List<OrderItem>();
       // public IEnumerable<OrderItem> OrderItems => _orderItems;
       public virtual IEnumerable<OrderItem> OrderItems => _orderItems;
        
        public double Total { get; protected set; }
        
        public Guid? TrackingCode { get; protected set; }
        
        public OrderStatus Status { get; protected set; }

        public OrderStates GetState()
        {
            return new OrderStates(this).Create();
        }
    }
}