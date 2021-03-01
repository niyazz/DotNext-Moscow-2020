using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class ShipOrderContext : BaseOrderContext<ShipOrderCommand>
    {
        public ShipOrderContext(ShipOrderCommand request, Order order)  : base (request, order){}
    }
}
