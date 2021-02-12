using Force.Cqrs;
using HightechAngular.Core.Services;

namespace HightechAngular.Shop.Features.Cart
{
    public class RemoveCartItemHandler : ICommandHandler<RemoveCartItem, bool>
    {
        private readonly ICartStorage _cartStorage;

        public RemoveCartItemHandler(ICartStorage cartStorage)
        {
            _cartStorage = cartStorage;
        }
        public bool Handle(RemoveCartItem input)
        {
            var res = _cartStorage.Cart.TryRemoveProduct(input.ProductId);
            _cartStorage.SaveChanges();
            return res;
        }
    }
}
