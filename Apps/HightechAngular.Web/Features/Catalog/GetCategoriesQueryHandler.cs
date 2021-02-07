using HightechAngular.Orders.Entities;
using Infrastructure.Cqrs.Read;
using System.Linq;

namespace HightechAngular.Web.Features.Catalog
{
    public class GetCategoriesQueryHandler : GetIntEnumerableQueryHandlerBase<GetCategoriesQuery, Category, CategoryListItem>
    {
        public GetCategoriesQueryHandler(IQueryable<Category> queryable) : base(queryable)
        {
        }
    }
}
