using Force.Cqrs;
using HightechAngular.Web.Features.Shared;

namespace HightechAngular.Web.Features.Admin
{
    public class GetAllOrdersCommand : FilterQuery<GetAllOrdersListItem>
    {
    }
}