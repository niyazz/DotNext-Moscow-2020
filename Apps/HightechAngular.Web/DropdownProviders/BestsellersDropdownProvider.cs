using System;
using System.Threading.Tasks;
using HightechAngular.Shop.Features.Index.GetBestsellers;
using Infrastructure.SwaggerSchema.Dropdowns;
using Infrastructure.SwaggerSchema.Dropdowns.Providers;

namespace HightechAngular.Shop.Features.Index
{
    public class BestsellersDropdownProvider : IDropdownProvider<GetBestsellersListItem>
    {
        private readonly IServiceProvider _serviceProvider;

        public BestsellersDropdownProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<Dropdowns> GetDropdownOptionsAsync()
        {
            return _serviceProvider.DropdownsFor<GetBestsellersListItem>();
        }
    }
}