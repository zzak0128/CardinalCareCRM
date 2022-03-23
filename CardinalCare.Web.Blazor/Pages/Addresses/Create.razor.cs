using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Addresses
{
    public partial class Create
    {
        [Inject] public AddressService AddressService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public Address NewAddress { get; set; } = new Address();

        private void NavigateBack()
        {
            NavManager.NavigateTo("/Address");
        }

        private async Task SaveAddressAsync()
        {
            await AddressService.AddAddressAsync(NewAddress);
            NavigateBack();
        }
    }
}
