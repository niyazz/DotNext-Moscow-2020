using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Infrastructure.Ddd.Domain.State;

namespace HightechAngular.Core.Entities
{
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public partial class Order : HasStateBase<OrderStatus, Order.OrderStateBase>
    {
        public static readonly OrderSpecs Specs = new OrderSpecs();

        protected Order(){}

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
        public virtual IEnumerable<OrderItem> OrderItems => _orderItems;

        private List<OrderItem> _orderItems = new List<OrderItem>();

        public DateTime Created { get; protected set; } = DateTime.UtcNow;
        
        public DateTime Updated { get; protected set; }
              
        public double Total { get; protected set; }
        
        public Guid? TrackingCode { get; protected set; }

        public override OrderStateBase GetState(OrderStatus status) =>
            status switch 
            { 
                OrderStatus.New  => new New(this),
                OrderStatus.Paid => new Paid(this),
                OrderStatus.Shipped => new Shipped(this),
                OrderStatus.Complete => new Complete(this),
                OrderStatus.Dispute => new Dispute(this),
                _ => throw new NotSupportedException($"Status \"{status}\" is not supported")
            };
    }
}