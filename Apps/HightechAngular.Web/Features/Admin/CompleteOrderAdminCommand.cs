using HightechAngular.Orders.Base;

namespace HightechAngular.Web.Features.Admin
{
    public class CompleteOrderAdminCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}