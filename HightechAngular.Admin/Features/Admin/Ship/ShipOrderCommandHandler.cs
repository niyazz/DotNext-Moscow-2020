using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
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
            return new HandlerResult<OrderStatus>(input.Order.Status);
        }
    }
}
