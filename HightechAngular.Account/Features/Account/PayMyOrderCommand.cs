using System.Threading.Tasks;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Account.Features.Account
{
    public class PayMyOrderCommand: ICommand<Task<HandlerResult<OrderStatus>>>
    {
        public int OrderId { get; set; }
    }
}