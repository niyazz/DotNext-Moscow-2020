using Force.Cqrs;
using Force.Ddd;

namespace HightechAngular.Shop.Features.Cart
{
    public class RemoveCartItemCommand : HasIdBase, ICommand<bool>
    {
        public int ProductId;
        public RemoveCartItemCommand(int productId)
        {
            ProductId = productId;
        }
    }
}
