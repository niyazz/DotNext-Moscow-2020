﻿using System;
using System.Threading.Tasks;
using HightechAngular.Shop.Features.Index.GetSale;
using Infrastructure.SwaggerSchema.Dropdowns;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;

namespace HightechAngular.Shop.Features.Index
{
    public class SaleListDropdownProvider: IDropdownProvider<GetSaleListItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public SaleListDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<GetSaleListItem>();
        }
    }
}