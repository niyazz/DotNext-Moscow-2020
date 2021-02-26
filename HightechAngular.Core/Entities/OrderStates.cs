using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Core.Entities
{
    public partial class Order : HasIdBase
    {
        public class OrderStates
        {
            private Order order;

            public OrderStates(Order order)
            {
                this.order = order;
            }

            public OrderStates Create() =>
                 order.Status switch
                 {
                     OrderStatus.New => new New(order),
                     OrderStatus.Paid => new Paid(order),
                     OrderStatus.Shipped => new Shipped(order),
                     OrderStatus.Complete => new Complete(order),
                     OrderStatus.Dispute => new Dispute(order),
                     _ => throw new NotImplementedException($"Not supported status: {order.Status}"),
                 };

            public class New : OrderStates
            {
                public New(Order order) :base(order){}
                public void BecomePaid()
                {
                    order.Status = OrderStatus.Paid;
                }
            }

            public class Paid : OrderStates
            {
                public Paid(Order order) : base(order){ }
                public void BecomeShipped()
                {
                    order.Status = OrderStatus.Shipped;
                }
            }

            public class Shipped : OrderStates
            {
                public Shipped(Order order) : base(order) { }
                public void BecomeComplete()
                {
                    order.Status = OrderStatus.Complete;
                }
                public void BecomeDispute()
                {
                    order.Status = OrderStatus.Dispute;
                }
            }

            public class Complete : OrderStates
            {
                public Complete(Order order) : base(order) { }
            }
            public class Dispute : OrderStates
            {
                public Dispute(Order order) : base(order) { }
            }
        }
    }
}



