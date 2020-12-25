using System;

namespace InternetStore.Entities
{
    public class OrderToProduct
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public int Quanity { get; set; }

    }
}
