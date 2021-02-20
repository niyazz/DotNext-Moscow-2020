using System;
using System.Threading.Tasks;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Admin.Features.Admin
{
    public class OrderController : ApiControllerBase
    {
        [HttpPut("PayOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PayOrder(
            [FromBody] PayOrderAdminCommand command,
            [FromServices] Func<PayOrderAdminCommand, PayOrderAdminContext> factory) =>
            await this.ProcessAsync(factory(command));
       

        [HttpGet("GetOrders")]
        [ProducesResponseType(typeof(GetAllOrdersListItem), StatusCodes.Status200OK)]
        public IActionResult GetOrders([FromQuery] GetAllOrdersQuery query) => 
            this.Process(query);

        [HttpPut("Shipped")]
        public async Task<IActionResult> Shipped(
            [FromBody] ShipOrderCommand command,
            [FromServices] Func<ShipOrderCommand, ShipOrderContext> factory) =>
            await this.ProcessAsync(factory(command));
       

        [HttpPut("Complete")]
        public async Task<IActionResult> Complete(
            [FromBody] CompleteOrderAdminCommand command,
            [FromServices] Func<CompleteOrderAdminCommand, CompleteOrderAdminContext> factory) =>
            await this.ProcessAsync(factory(command));

    }
}