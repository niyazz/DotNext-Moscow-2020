using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class CompleteOrderCommandHandler : ICommandHandler<CompleteOrderContext, Task<HandlerResult<OrderStatus>>>
    {
        public CompleteOrderCommandHandler(){}

        public async Task<HandlerResult<OrderStatus>> Handle(CompleteOrderContext input)
        {
            await Task.Delay(1000);
            var result = input.Order.With
                ((Order.Dispute disputeOrder) => disputeOrder.BecomeComplete());
            return new HandlerResult<OrderStatus>(result!.EligibleStatus);
        }
    }
}
