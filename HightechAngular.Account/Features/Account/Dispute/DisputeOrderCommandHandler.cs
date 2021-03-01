using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
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
            var shipState = new Order.OrderStates.Shipped(input.Order);
            shipState.BecomeDispute();
            return new HandlerResult<OrderStatus>(input.Order.Status);
        }
    }
}
