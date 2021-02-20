using System;
using System.Collections.Generic;
using System.Net;
using Force.Extensions;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Services;
using HightechAngular.Shop.Features.Cart.Add;
using HightechAngular.Shop.Features.Cart.Remove;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Features.Cart
{
    public class CartController : ApiControllerBase
    {
        [HttpGet]
        public ActionResult<List<CartItem>> Get([FromServices] ICartStorage storage) =>
            storage.Cart.CartItems.PipeTo(Ok);

        [HttpPut("Add")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public IActionResult Add(
            [FromBody] int productId,
            [FromServices] Func<AddCartItemCommand, AddCartItemContext> factory) =>  
            this.Process(factory(new AddCartItemCommand(productId)));
        

        [HttpPut("Remove")]
        public ActionResult<bool> Remove(
            [FromBody] int productId,
            [FromServices] Func<RemoveCartItemCommand, RemoveCartItemContext> factory) =>
            this.Process(factory(new RemoveCartItemCommand(productId)));
    }
}