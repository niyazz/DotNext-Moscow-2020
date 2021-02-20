using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;

namespace HightechAngular.Shop.Features.Cart.Remove
{
    public class RemoveCartItemContext : OperationContextBase<RemoveCartItemCommand>, ICommand<bool>
    {
        [Required]
        public Product Product { get; }

        public RemoveCartItemContext(RemoveCartItemCommand request, Product product) : base(request)
        {
            Product = product;
        }
    }

}
