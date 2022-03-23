using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Addresses
{
    public partial class Index
    {
        [Inject] public AddressService AddressService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public List<Address> AllAddresses { get; set; } = new List<Address>();

        protected override async Task OnInitializedAsync()
        {
            AllAddresses = await AddressService.GetAddressesAsync();
        }

        private void NavigateToCreate()
        {
            NavManager.NavigateTo("/address/create");
        }

        private async Task DeleteAddressAsync(Address address)
        {
            AllAddresses.Remove(address);
            await AddressService.DeleteAddressAsync(address);
        }
    }
}
