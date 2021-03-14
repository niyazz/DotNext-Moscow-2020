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
        // через public TState State { get; }, пока не выйдет, поскольку IHasOrderState<TState> появляется на 7-ом шаге
        public BaseOrderContext(T request) : base(request){}
    }
}
