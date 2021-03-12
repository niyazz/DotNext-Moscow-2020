using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.Workflow;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class DisputeOrderCommandHandler : ICommandHandler<DisputeOrderContext, Task<HandlerResult<OrderStatus>>>
    {

        public DisputeOrderCommandHandler(){}

        public async Task<HandlerResult<OrderStatus>> Handle(DisputeOrderContext input)
        {
            await Task.Delay(1000);
            var result = input.Order.With
                ((Order.Shipped shippedOrder) => shippedOrder.BecomeDispute());
            return result == null
               ? new HandlerResult<OrderStatus>(FailureInfo.Invalid("Order is in invalid state"))
               : new HandlerResult<OrderStatus>(result.EligibleStatus);
        }
    }
}
