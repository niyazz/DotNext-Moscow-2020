using Force.Cqrs;
using HightechAngular.Core.Entities;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace HightechAngular.Shop.Features.Index.GetBestsellers
{
    public class GetBestsellerQueryHandler : IQueryHandler<GetBestsellersQuery, IEnumerable<GetBestsellersListItem>>
    {
        private readonly IQueryable<Product> _products;
        public GetBestsellerQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }
        public IEnumerable<GetBestsellersListItem> Handle(GetBestsellersQuery input) =>
            _products
             .Where(Product.Specs.IsBestseller)
             .ProjectToType<GetBestsellersListItem>()
             .ToList();
    }
}
