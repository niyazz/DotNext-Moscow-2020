using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class PayOrderAdminCommandHandler : ICommandHandler<PayOrderAdminContext, Task<HandlerResult<OrderStatus>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayOrderAdminCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<HandlerResult<OrderStatus>> Handle(PayOrderAdminContext input)
        {
            await Task.Delay(1000);
            var result = input.Order.With
                ((Order.New newOrder) => newOrder.BecomePaid());
            _unitOfWork.Commit();
            return new HandlerResult<OrderStatus>(input.Order.Status);
        }
    }
}
