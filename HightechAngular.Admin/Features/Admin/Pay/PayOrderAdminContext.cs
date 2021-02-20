using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class PayOrderAdminContext : 
        ByIntIdOperationContextBase<PayOrderAdminCommand>,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
        [Required]
        public Order Order { get; }

        public PayOrderAdminContext(PayOrderAdminCommand request, Order order) : base(request)
        {
            Order = order;
        }
    }
}
