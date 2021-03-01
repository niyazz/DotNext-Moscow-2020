using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Core.Base
{
    public class BaseOrderContext<T> :
        ByIntIdOperationContextBase<T>,
        ICommand<Task<HandlerResult<OrderStatus>>> where T: class, IHasId<int>
    {
        [Required]
        public Order Order { get; }

        public BaseOrderContext(T request, Order order) : base(request)
        {
            Order = order;
        }
    }
}
