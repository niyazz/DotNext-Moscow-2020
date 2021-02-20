using HightechAngular.Admin.Features.Admin;
using HightechAngular.Admin.Features.OrderManagement;
using HightechAngular.Core.Features.Shared;
using HightechAngular.Shop.Features.MyOrders;
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