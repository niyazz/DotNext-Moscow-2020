using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class PayOrderAdminContext : BaseOrderContext<PayOrderAdminCommand>
    {
        public PayOrderAdminContext(PayOrderAdminCommand request, Order order) : base(request, order) { }
    }
}
