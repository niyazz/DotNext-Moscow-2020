using System;
using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;

namespace HightechAngular.Admin.Features.Admin
{
    public class PayOrderAdminCommand : HasIdBase, ICommand<Task<HandlerResult<OrderStatus>>>
    {
        public int OrderId { get; set; } 
    }
}