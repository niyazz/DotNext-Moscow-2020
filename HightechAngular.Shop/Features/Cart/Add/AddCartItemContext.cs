using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;

namespace HightechAngular.Shop.Features.Cart.Add
{
    public class AddCartItemContext : BaseCartContext<AddCartItemCommand>, ICommand
    {
        public AddCartItemContext(AddCartItemCommand request, Product product) : base(request, product) {}
    }
}
