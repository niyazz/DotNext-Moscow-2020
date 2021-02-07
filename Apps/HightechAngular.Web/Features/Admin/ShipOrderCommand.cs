using HightechAngular.Orders.Base;
using HightechAngular.Orders.Entities;

namespace HightechAngular.Web.Features.Admin
{
    public class ShipOrderCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}