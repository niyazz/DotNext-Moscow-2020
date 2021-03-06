using System.Collections.Generic;
using System.Net;
using Force.Extensions;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Services;
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
        public IActionResult Add([FromBody] int productId) =>  
            this.Process(new AddCartItem(productId));
        

        [HttpPut("Remove")]
        public ActionResult<bool> Remove([FromBody] int productId) =>
            this.Process(new RemoveCartItem(productId));
    }
}