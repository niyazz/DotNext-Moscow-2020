using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class DisputeOrderContext :
        ByIntIdOperationContextBase<DisputeOrderCommand>,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
        [Required]
        public Order Order { get; }

        public DisputeOrderContext(DisputeOrderCommand request, Order order)  : base(request)
        {
            this.Order = order;
        }
    }
}
