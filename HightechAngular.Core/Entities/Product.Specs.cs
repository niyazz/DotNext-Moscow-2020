using Force.Ddd;
using HightechAngular.Core.Entities;

namespace HightechAngular.Orders.Entities
{
    public class ProductSpecs
    {
        internal ProductSpecs()
        {
            IsBestseller = IsForSale && new Spec<Product>(x => x.PurchaseCount > 10);
        }

        public Spec<Product> IsForSale { get; } = new Spec<Product>(x => x.Price > 0);
        
        public Spec<Product> IsBestseller { get;  }
    }
}