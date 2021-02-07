using Force.Cqrs;
using Force.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Web.Features.Cart
{
    public class AddCartItem : HasIdBase, ICommand
    {
        public int ProductId;

        public AddCartItem(int productId)
        {
            ProductId = productId;
        }  
    }
}
