using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class CompleteOrderAdminContext : BaseOrderContext<CompleteOrderAdminCommand>
    {
        public CompleteOrderAdminContext(CompleteOrderAdminCommand request, Order order) : base(request, order) { }
    }
}
