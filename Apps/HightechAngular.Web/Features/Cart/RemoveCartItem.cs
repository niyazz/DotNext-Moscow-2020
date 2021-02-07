using Force.Cqrs;
using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Features.Cart
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
