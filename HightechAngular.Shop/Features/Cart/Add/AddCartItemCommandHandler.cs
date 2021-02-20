using Force.Cqrs;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Services;
using HightechAngular.Shop.Features.Cart.Add;
using System.Linq;

namespace HightechAngular.Shop.Features.Cart
{
    public class AddCartItemCommandHandler : ICommandHandler<AddCartItemContext>
    {
        private readonly ICartStorage _cartStorage;

        public AddCartItemCommandHandler(ICartStorage cartStorage)
        {
            _cartStorage = cartStorage;
        }

        public void Handle(AddCartItemContext input)
        {
            _cartStorage.Cart.AddProduct(input.Product);
            _cartStorage.SaveChanges();
        }
    }
}
