using Force.Cqrs;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Services;
using System.Linq;

namespace HightechAngular.Shop.Features.Cart
{
    public class AddCartItemHandler : ICommandHandler<AddCartItem>
    {
        private readonly ICartStorage _cartStorage;
        private readonly IQueryable<Product> _products;

        public AddCartItemHandler(ICartStorage cartStorage, IQueryable<Product> products)
        {
            _cartStorage = cartStorage;
            _products = products;
        }

        public void Handle(AddCartItem input)
        {
            var product = _products.First(x => x.Id == input.ProductId);
            _cartStorage.Cart.AddProduct(product);
            _cartStorage.SaveChanges();
        }
    }
}
