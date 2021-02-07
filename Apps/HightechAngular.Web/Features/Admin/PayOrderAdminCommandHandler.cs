using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Orders.Entities;
using Infrastructure.Cqrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Features.Admin
{
    public class PayOrderAdminCommandHandler : ICommandHandler<PayOrderAdminCommand, Task<HandlerResult<OrderStatus>>>
    {
        private readonly IQueryable<Order> _orders;
        private readonly IUnitOfWork _unitOfWork;
        public PayOrderAdminCommandHandler(IQueryable<Order> orders, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _orders = orders;
        }
        public async Task<HandlerResult<OrderStatus>> Handle(PayOrderAdminCommand input)
        {
            await Task.Delay(1000);
            var order = _orders.First(x => x.Id == input.OrderId);
            var result = order.BecomePaid();
            _unitOfWork.Commit();
            return new HandlerResult<OrderStatus>(result);
        }
    }
}
