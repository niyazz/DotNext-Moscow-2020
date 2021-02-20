using HightechAngular.Admin.Features.Admin;
using HightechAngular.Core.Entities;
using Infrastructure.Cqrs.Read;
using System.Linq;

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
