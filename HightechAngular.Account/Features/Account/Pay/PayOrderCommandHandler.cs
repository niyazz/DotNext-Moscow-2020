using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.Workflow;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class PayMyOrderCommandHandler : ICommandHandler<PayMyOrderContext, Task<HandlerResult<OrderStatus>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PayMyOrderCommandHandler(
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<HandlerResult<OrderStatus>> Handle(PayMyOrderContext input)
        {
            await Task.Delay(1000);
            var result = input.Order.With
                ((Order.New newOrder) => newOrder.BecomePaid());
            _unitOfWork.Commit();
            return result == null
              ? new HandlerResult<OrderStatus>(FailureInfo.Invalid("Order is in invalid state"))
              : new HandlerResult<OrderStatus>(result.EligibleStatus);
        }
    }
}
