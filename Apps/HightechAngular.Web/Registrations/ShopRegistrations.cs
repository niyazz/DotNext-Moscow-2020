using HightechAngular.Orders.Entities;
using HightechAngular.Orders.Services;
using HightechAngular.Shop.Features.Cart;
using HightechAngular.Shop.Features.Catalog;
using HightechAngular.Shop.Features.Index;
using HightechAngular.Web.Features.Index;
using HightechAngular.Web.Features.Index.Controller.GetNewArrivals;
using HightechAngular.Web.Features.Index.GetBestsellers;
using HightechAngular.Web.Features.Index.GetSale;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace HightechAngular.Shop
{
    public static class ShopRegistrations
    {
        public static void RegisterShop(this IServiceCollection services)
        {
            services.AddScoped<ICartStorage, CartStorage>();
            services.AddScoped<IDropdownProvider<ProductListItem>, ProductsDropdownProvider>();
            services.AddScoped<IDropdownProvider<GetBestsellersListItem>, BestsellersDropdownProvider>();
            services.AddScoped<IDropdownProvider<GetNewArrivalsListItem>, NewArrivalsDropdownProvider>();
            services.AddScoped<IDropdownProvider<GetSaleListItem>, SaleListDropdownProvider>();
            services.AddScoped<IDropdownProvider<CartItem>, CartDropdownProvider>();
        }
    }
}