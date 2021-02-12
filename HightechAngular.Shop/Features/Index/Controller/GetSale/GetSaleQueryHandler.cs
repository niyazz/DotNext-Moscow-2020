using Force.Cqrs;
using HightechAngular.Core.Entities;
using HightechAngular.Shop.Features.Index.GetSale;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace HightechAngular.Shop.Features.Index.Controller.GetSale
{
    public class GetSaleQueryHandler : IQueryHandler<GetSaleQuery, IEnumerable<GetSaleListItem>>
    {
        private readonly IQueryable<Product> _products;
        public GetSaleQueryHandler(IQueryable<Product> products)
        {
            _products = products;
        }
        public IEnumerable<GetSaleListItem> Handle(GetSaleQuery input) =>
            _products
                .Where(x => x.DiscountPercent > 0)
                .ProjectToType<GetSaleListItem>();
    }
}
