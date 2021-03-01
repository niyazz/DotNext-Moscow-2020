using Force.Cqrs;
using Force.Ddd;
using HightechAngular.Core.Entities;
using Infrastructure.OperationContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HightechAngular.Core.Base
{
    public class BaseCartContext<T> : OperationContextBase<T>
        where T : class
    {
        [Required]
        public Product Product { get; }

        public BaseCartContext(T request, Product product) : base(request)
        {
            Product = product;
        }
    }
}
