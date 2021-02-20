using Force.Cqrs;
using HightechAngular.Core.Entities;
using Infrastructure.OperationContext;
using System.ComponentModel.DataAnnotations;

namespace HightechAngular.Shop.Features.Cart.Add
{
    public class AddCartItemContext : OperationContextBase<AddCartItemCommand>, ICommand
    {
        [Required]
        public Product Product { get; }

        public AddCartItemContext(AddCartItemCommand request, Product product) : base(request)
        {
            Product = product;
        }
    }
}
