using Force.Cqrs;
using HightechAngular.Core.Services;
using HightechAngular.Shop.Features.Cart.Remove;

namespace HightechAngular.Shop.Features.Cart
{
    public class RemoveCartItemHandlerCommand : ICommandHandler<RemoveCartItemContext, bool>
    {
        private readonly ICartStorage _cartStorage;

        public RemoveCartItemHandlerCommand(ICartStorage cartStorage)
        {
            _cartStorage = cartStorage;
        }
        public bool Handle(RemoveCartItemContext input)
        {
            var res = _cartStorage.Cart.TryRemoveProduct(input.Product.Id);
            _cartStorage.SaveChanges();
            return res;
        }
    }
}
