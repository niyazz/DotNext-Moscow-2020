using Force.Cqrs;
using HightechAngular.Orders.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Features.Index.GetBestsellers
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
