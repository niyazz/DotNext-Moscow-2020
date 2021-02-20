using System.Collections.Generic;
using Force.Cqrs;
using HightechAngular.Shop.Features.Index.Controller.GetNewArrivals;
using HightechAngular.Shop.Features.Index.GetBestsellers;
using HightechAngular.Shop.Features.Index.GetSale;
using Infrastructure.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HightechAngular.Shop.Features.Index.Controller
{
    [Route("api")]
    public class IndexController: ApiControllerBase
    {
        [HttpGet("Bestsellers")]
        public ActionResult<IEnumerable<GetBestsellersListItem>> Get(
            [FromServices] IQueryHandler<GetBestsellersQuery, IEnumerable<GetBestsellersListItem>> handler,
            [FromQuery] GetBestsellersQuery query) =>
                Ok(handler.Handle(query));

        [HttpGet("NewArrivals")]
        [ProducesResponseType(typeof(GetNewArrivalsListItem), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<GetNewArrivalsListItem>> Get(
            [FromServices] IQueryHandler<GetNewArrivalsQuery, IEnumerable<GetNewArrivalsListItem>> handler,
            [FromQuery] GetNewArrivalsQuery query) =>
                Ok(handler.Handle(query));


        [HttpGet("Sale")]
        public ActionResult<IEnumerable<GetSaleListItem>> Get(
            [FromServices] IQueryHandler<GetSaleQuery, IEnumerable<GetSaleListItem>> handler,
            [FromQuery] GetSaleQuery query) =>
                Ok(handler.Handle(query));
    }
}