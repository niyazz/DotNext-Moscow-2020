using HightechAngular.Admin.Features.Admin;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs.Read;
using System.Linq;

namespace HightechAngular.Web.Features.Admin
{
    public class GetAllOrdersQueryHandler : GetIntEnumerableQueryHandlerBase<GetAllOrdersQuery, Order, GetAllOrdersListItem>
    {
        public GetAllOrdersQueryHandler(IQueryable<Order> queryable) : base(queryable)
        {
        }

        protected override IQueryable<GetAllOrdersListItem> Map(IQueryable<Order> queryable, GetAllOrdersQuery query) =>
            queryable.Select(GetAllOrdersListItem.Map);
    }
}
