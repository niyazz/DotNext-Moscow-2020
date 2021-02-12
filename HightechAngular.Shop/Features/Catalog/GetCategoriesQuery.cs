using System.Collections.Generic;
using Force.Cqrs;

namespace HightechAngular.Shop.Features.Catalog
{
    public class GetCategoriesQuery: IQuery<IEnumerable<CategoryListItem>>
    {
    }
}