using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HightechAngular.Core.Features.Shared;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Account.Features.Account
{
    public class MyOrdersController : ApiControllerBase
    {
        [HttpPost("CreateNew")]
        [Authorize]
        public ActionResult<int> CreateNew([FromBody] CreateOrderCommand command) 
            => this.Process(command);

        [HttpGet("GetMyOrders")]
        public ActionResult<IEnumerable<OrderListItem>> GetMyOrders([FromQuery] GetMyOrdersQuery query)
            => this.Process(query);

        [HttpPut("Dispute")]
        public async Task<IActionResult> Dispute(
            [FromBody] DisputeOrderCommand command,
            [FromServices] Func<DisputeOrderCommand, DisputeOrderContext> factory)
            => await this.ProcessAsync(factory(command));

        [HttpPut("Complete")]
        public async Task<IActionResult> Complete(
            [FromBody] CompleteOrderCommand command,
            [FromServices] Func<CompleteOrderCommand, CompleteOrderContext> factory)
            => await this.ProcessAsync(factory(command));

        [HttpPut("PayOrder")]
        public async Task<IActionResult> PayOrder(
            [FromBody] PayMyOrderCommand command,
            [FromServices] Func<PayMyOrderCommand, PayMyOrderContext> factory)
            => await this.ProcessAsync(factory(command));
    }
}