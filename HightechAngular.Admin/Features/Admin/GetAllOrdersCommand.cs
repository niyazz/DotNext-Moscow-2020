using Force.Cqrs;
using HightechAngular.Web.Features.Admin;

namespace HightechAngular.Admin.Features.Admin
{
    public class GetAllOrdersCommand : FilterQuery<GetAllOrdersListItem>
    {
    }
}