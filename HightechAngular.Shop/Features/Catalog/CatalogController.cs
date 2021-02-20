using System.Linq;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Features.Shared;
using HightechAngular.Orders.Entities;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Features.Catalog
{
    public class CatalogController: ApiControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ProductListItem), StatusCodes.Status200OK)]
        public IActionResult Get([FromQuery] GetProductsQuery query)
            => this.Process(query);

        [HttpGet("GetCategories")]
        public IActionResult GetCategories() => this.Process(new GetCategoriesQuery());
    }
}