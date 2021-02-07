using HightechAngular.Orders.Base;

namespace HightechAngular.Web.Features.Account
{
    public class DisputeOrderCommand : ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}