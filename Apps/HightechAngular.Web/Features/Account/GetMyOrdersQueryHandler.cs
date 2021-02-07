using HightechAngular.Orders.Entities;
using HightechAngular.Web.Features.Shared;
using Infrastructure.Cqrs.Read;
using System.Linq;

namespace HightechAngular.Web.Features.Account
{
    public class GetMyOrdersQueryHandler : GetIntEnumerableQueryHandlerBase<GetMyOrdersQuery, Order, OrderListItem>
    {
        public GetMyOrdersQueryHandler(IQueryable<Order> queryable) : base(queryable)
        {
        }

        protected override IQueryable<OrderListItem> Map(IQueryable<Order> queryable, GetMyOrdersQuery query) =>
            queryable.Select(OrderListItem.Map);
    }
}
