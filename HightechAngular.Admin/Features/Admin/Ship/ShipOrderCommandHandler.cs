using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class ShipOrderCommandHandler : ICommandHandler<ShipOrderContext, Task<HandlerResult<OrderStatus>>>
    {
        private readonly IQueryable<Order> _orders;
        public ShipOrderCommandHandler(IQueryable<Order> orders)
        {
            _orders = orders;
        }
        public async Task<HandlerResult<OrderStatus>> Handle(ShipOrderContext input)
        {
            await Task.Delay(1000);
            var paidState = new Order.OrderStates.Paid(input.Order);
            paidState.BecomeShipped();
            return new HandlerResult<OrderStatus>(input.Order.Status);
        }
    }
}
