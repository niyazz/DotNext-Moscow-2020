﻿using System;
using System.Threading.Tasks;
using HightechAngular.Admin.Features.Admin;
using Infrastructure.SwaggerSchema.Dropdowns;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;

namespace HightechAngular.Admin.Features.OrderManagement
{
    public class PayOrderDropdownProvider : IDropdownProvider<PayOrderAdminCommand>
    {
        private readonly IServiceProvider _serviceProvider;

        public PayOrderDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<PayOrderAdminCommand>();
        }
    }
}