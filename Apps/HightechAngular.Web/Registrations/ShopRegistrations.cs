using HightechAngular.Core.Entities;
using HightechAngular.Core.Features.Shared;
using HightechAngular.Core.Services;
using HightechAngular.Shop.Features.Cart;
using HightechAngular.Shop.Features.Catalog;
using HightechAngular.Shop.Features.Index;
using HightechAngular.Shop.Features.Index.Controller.GetNewArrivals;
using HightechAngular.Shop.Features.Index.GetBestsellers;
using HightechAngular.Shop.Features.Index.GetSale;
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