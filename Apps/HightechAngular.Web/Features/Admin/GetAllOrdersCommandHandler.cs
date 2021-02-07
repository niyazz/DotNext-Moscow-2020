using HightechAngular.Orders.Entities;
using HightechAngular.Web.Features.Shared;
using Infrastructure.Cqrs.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Features.Admin
{
    public class GetAllOrdersCommandHandler : GetIntEnumerableQueryHandlerBase<GetAllOrdersCommand, Order, GetAllOrdersListItem>
    {
        public GetAllOrdersCommandHandler(IQueryable<Order> queryable) : base(queryable)
        {
        }

        protected override IQueryable<GetAllOrdersListItem> Map(IQueryable<Order> queryable, GetAllOrdersCommand query) =>
            queryable.Select(GetAllOrdersListItem.Map);
    }
}
