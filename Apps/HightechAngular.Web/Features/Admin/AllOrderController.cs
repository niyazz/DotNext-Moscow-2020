using System;
using System.Linq;
using System.Threading.Tasks;
using Force.Ccc;
using Force.Extensions;
using HightechAngular.Orders.Entities;
using HightechAngular.Web.Features.Shared;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Web.Features.Admin
{
    public class OrderController : ApiControllerBase
    {
        [HttpPut("PayOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PayOrder([FromBody] PayOrderAdminCommand command) =>
            await this.ProcessAsync(command);
       

        [HttpGet("GetOrders")]
        [ProducesResponseType(typeof(GetAllOrdersListItem), StatusCodes.Status200OK)]
        public IActionResult GetOrders([FromQuery] GetAllOrdersCommand query) => 
            this.Process(query);

        [HttpPut("Shipped")]
        public async Task<IActionResult> Shipped([FromBody] ShipOrderCommand command) =>
            await this.ProcessAsync(command);
       

        [HttpPut("Complete")]
        public async Task<IActionResult> Complete([FromBody] CompleteOrderAdminCommand command) =>
            await this.ProcessAsync(command);

    }
}