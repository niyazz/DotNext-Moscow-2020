using Force.Cqrs;
using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Shop.Features.Cart
{
    public class AddCartItemCommand : HasIdBase, ICommand
    {
        public int ProductId;

        public AddCartItemCommand(int productId)
        {
            ProductId = productId;
        }  
    }
}
