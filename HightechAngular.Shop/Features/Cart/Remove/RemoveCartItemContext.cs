using Force.Cqrs;
using HightechAngular.Core.Base;
using HightechAngular.Core.Entities;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;

namespace HightechAngular.Shop.Features.Cart.Remove
{
    public class RemoveCartItemContext : BaseCartContext<RemoveCartItemCommand>, ICommand<bool>
    {
        public RemoveCartItemContext(RemoveCartItemCommand request, Product product) : base(request, product) { }
    }
}
