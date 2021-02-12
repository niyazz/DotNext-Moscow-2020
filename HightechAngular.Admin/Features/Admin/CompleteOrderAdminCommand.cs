using HightechAngular.Core.Entities;

namespace HightechAngular.Admin.Features.Admin
{
    public class CompleteOrderAdminCommand: ChangeOrderStateBase
    {
        public int   OrderId { get; set; }
    }
}