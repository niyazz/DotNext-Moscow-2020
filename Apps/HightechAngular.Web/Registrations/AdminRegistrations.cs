using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Shop.Features.MyOrders;
using HightechAngular.Web.Features.Account;
using HightechAngular.Web.Features.Admin;
using HightechAngular.Web.Features.Shared;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace HightechAngular.Admin
{
    public static class AdminRegistrations
    {
        public static void RegisterAdmin(this IServiceCollection services)
        {
            services.AddScoped<IDropdownProvider<PayOrderAdminCommand>, PayOrderDropdownProvider>();
            services.AddScoped<IDropdownProvider<OrderListItem>, OrderListItemDropdownProvider>();
            services.AddScoped<IDropdownProvider<GetAllOrdersListItem>, CreateOrderDropdownProvider>();
        }
    }
}