using System;
using System.Collections.Generic;
using InternetStore.Enums;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.Entities
{
    public class Order
    {
        public Order()
        {
            OrderToProduct = new List<OrderToProduct>();
        }

        public Order(Cart cart, string customerPasportNumber)
        {
            this.Id = new Guid();
            this.CreatedAt = DateTime.Now;
            this.CustomerPassportNumber = customerPasportNumber;
            this.TotalPrice = cart.ComputeTotalValue();
            OrderToProduct = new List<OrderToProduct>();
            this.Status = OrderStatus.Packing;
        }

        [HiddenInput(DisplayValue = false)]
        public Guid Id { get; set; }
        public string CustomerPassportNumber { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderToProduct> OrderToProduct { get; set; }
        public OrderStatus Status { get; set; }
    }
}
