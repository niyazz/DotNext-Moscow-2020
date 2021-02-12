using HightechAngular.Core.Entities;

namespace HightechAngular.Admin.Features.Admin
{
    public class ShipOrderCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}