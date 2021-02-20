using System.Linq;
using Force.Cqrs;
using HightechAngular.Core.Features.Shared;

namespace HightechAngular.Core.Features.Shared
{
    public class GetProductsQuery: FilterQuery<ProductListItem>
    {
        public string[] Name { get; set; }
        public double[] Price { get; set; }
        public int CategoryId { get; set; }
        public GetProductsQuery()
        {
            Order = "Id";
            CategoryId = 1;
        }

        public override IQueryable<ProductListItem> Filter(IQueryable<ProductListItem> queryable)
        {
            return base.Filter(queryable.Where(x => x.CategoryId == CategoryId));
        }

        public override IOrderedQueryable<ProductListItem> Sort(IQueryable<ProductListItem> queryable)
        {
            if (Order == "dateCreated")
            {
                return Asc ? queryable.OrderByDescending(x => x.DateCreated) : queryable.OrderBy(x => x.DateCreated);
            }
            return base.Sort(queryable);
        }
    }
}