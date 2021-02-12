using Force.Cqrs;
using Force.Ddd;

namespace HightechAngular.Shop.Features.Cart
{
    public class RemoveCartItem : HasIdBase, ICommand<bool>
    {
        public int ProductId;
        public RemoveCartItem(int productId)
        {
            ProductId = productId;
        }
    }
}
