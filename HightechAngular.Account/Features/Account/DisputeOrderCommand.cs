using HightechAngular.Core.Entities;

namespace HightechAngular.Account.Features.Account
{
    public class DisputeOrderCommand : ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}