using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Account.Features.Account
{
    public class DisputeOrderContext : BaseOrderContext<DisputeOrderCommand>
    {
        public DisputeOrderContext(DisputeOrderCommand request, Order order) : base(request, order){ }
    }
}
