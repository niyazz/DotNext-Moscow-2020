using InternetStore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetStore.Models
{
    public class OrderEditModel
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
    }
}
