using System.Linq;
using HightechAngular.Orders.Entities;
using HightechAngular.Shop.Features.Catalog;
using HightechAngular.Web.Features.Index;
using Infrastructure.AspNetCore;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Web.Features.Catalog
{
    public class CatalogController: ApiControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ProductListItem), StatusCodes.Status200OK)]
        public IActionResult Get([FromQuery] GetProducts query)
            => this.Process(query);

        [HttpGet("GetCategories")]
        public IActionResult GetCategories() => this.Process(new GetCategoriesQuery());
    }
}