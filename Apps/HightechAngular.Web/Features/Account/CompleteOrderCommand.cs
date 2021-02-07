using HightechAngular.Orders.Base;

namespace HightechAngular.Web.Features.Account
{
    public class CompleteOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}