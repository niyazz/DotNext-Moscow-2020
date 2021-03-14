using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class CompleteOrderContext : BaseOrderContext<CompleteOrderCommand>
    {
        public CompleteOrderContext(CompleteOrderCommand request, Order.Dispute disputedOrder) : base(request)
        {
            DisputedOrder = disputedOrder;
        }
        [Required]
        public Order.Dispute DisputedOrder { get; }
    }
}
