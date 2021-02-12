using Force.Cqrs;
using HightechAngular.Core.Entities;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace HightechAngular.Shop.Features.Index.Controller.GetNewArrivals
{
    public class GetNewArrivalsQueryHandler : IQueryHandler<GetNewArrivalsQuery, IEnumerable<GetNewArrivalsListItem>>
    {
        private readonly IQueryable<Product> _products;
        public GetNewArrivalsQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }
        public IEnumerable<GetNewArrivalsListItem> Handle(GetNewArrivalsQuery input) =>
          _products
             .ProjectToType<GetNewArrivalsListItem>()
             .OrderByDescending(x => x.DateCreated)
             .Take(4);  
    }
}
