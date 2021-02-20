using System.Threading.Tasks;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Account.Features.Account
{
    public class PayMyOrderCommand: ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}