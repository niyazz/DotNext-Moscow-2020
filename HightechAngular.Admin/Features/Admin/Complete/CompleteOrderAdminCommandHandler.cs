﻿using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs;
using Infrastructure.Workflow;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Admin.Features.Admin
{
    public class CompleteOrderAdminCommandHandler : ICommandHandler<CompleteOrderAdminContext, Task<HandlerResult<OrderStatus>>>
    {
        public CompleteOrderAdminCommandHandler(){}
        public async Task<HandlerResult<OrderStatus>> Handle(CompleteOrderAdminContext input)
        {
            await Task.Delay(1000);
            var result = input.DisputeOrder.BecomeComplete();
            return new HandlerResult<OrderStatus>(result.EligibleStatus);
        }
    }
}
