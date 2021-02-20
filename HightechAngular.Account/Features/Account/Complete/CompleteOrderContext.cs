using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class CompleteOrderContext :
        ByIntIdOperationContextBase<CompleteOrderCommand>,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
        [Required]
        public Order Order { get; }

        public CompleteOrderContext(CompleteOrderCommand request, Order order) : base(request)
        {
            Order = order;
        }
    }
}
