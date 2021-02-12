using HightechAngular.Core.Entities;

namespace HightechAngular.Account.Features.Account
{
    public class CompleteOrderCommand : ChangeOrderStateBase
    {
        public int OrderId { get; set; }
    }
}