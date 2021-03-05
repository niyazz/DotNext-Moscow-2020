using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Ddd.Domain.State;

namespace HightechAngular.Core.Entities
{
    public partial class Order : HasStateBase<OrderStatus, Order.OrderStateBase>
    {
        public abstract class OrderStateBase : SingleStateBase<Order, OrderStatus>
        {
            protected OrderStateBase(Order entity) : base(entity){}
        }

        /// <summary>
        /// Represents new order, OrderStatus.New
        /// </summary>
        public class New : OrderStateBase
        {
            public New(Order entity) : base(entity) { }
            public override OrderStatus EligibleStatus => OrderStatus.New;
            public Paid BecomePaid() => Entity.To<Paid>(OrderStatus.Paid);

        }

        /// <summary>
        /// Represents paid order, OrderStatus.Paid
        /// </summary>
        public class Paid : OrderStateBase
        {
            public Paid(Order entity) : base(entity) { }
            public override OrderStatus EligibleStatus => OrderStatus.Paid;
            public Shipped BecomeShipped() => Entity.To<Shipped>(OrderStatus.Shipped);
            
        }

        /// <summary>
        /// Represents shipped order, OrderStatus.Shipped
        /// </summary>
        public class Shipped : OrderStateBase
        {
            public Shipped(Order entity) : base(entity) { }
            public override OrderStatus EligibleStatus => OrderStatus.New;
            public Dispute BecomeDispute() => Entity.To<Dispute>(OrderStatus.Dispute);
            public Complete BecomeComplete() => Entity.To<Complete>(OrderStatus.Dispute);
        }

        /// <summary>
        /// Represents dispute order, OrderStatus.Dispute
        /// </summary>
        public class Dispute : OrderStateBase
        {
            public Dispute(Order entity) : base(entity) { }
            public override OrderStatus EligibleStatus => OrderStatus.Dispute;
            public Complete BecomeComplete() => Entity.To<Complete>(OrderStatus.Complete);
        }

        /// <summary>
        /// Represents complete order, OrderStatus.Paid
        /// </summary>
        public class Complete : OrderStateBase
        {
            public Complete(Order entity) : base(entity) { }
            public override OrderStatus EligibleStatus => OrderStatus.Complete;
        }
    }
}



