using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using Infrastructure.Cqrs;

namespace HightechAngular.Core.Entities
{
    public abstract class ChangeOrderStateBase: 
        HasIdBase,
        ICommand<Task<HandlerResult<OrderStatus>>>
    {
    }
}