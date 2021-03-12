using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.Workflow;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class ShipOrderCommandHandler : ICommandHandler<ShipOrderContext, Task<HandlerResult<OrderStatus>>>
    {
        public ShipOrderCommandHandler() { }
        public async Task<HandlerResult<OrderStatus>> Handle(ShipOrderContext input)
        {
            await Task.Delay(1000);
            var result = input.Order.With(
                (Order.Paid paidOrder) => paidOrder.BecomeShipped());
            return result == null
              ? new HandlerResult<OrderStatus>(FailureInfo.Invalid("Order is in invalid state"))
              : new HandlerResult<OrderStatus>(result.EligibleStatus);
        }
    }
}
