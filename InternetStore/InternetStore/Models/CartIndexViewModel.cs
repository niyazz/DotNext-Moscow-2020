using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetStore.Entities;
namespace InternetStore.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string CustomerPassportNumber { get; set; }
    }
}
