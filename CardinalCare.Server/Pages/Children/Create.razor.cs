using System;
using Microsoft.AspNetCore.Components;
using CardinalCare.Server.Service;
using CardinalCare.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CardinalCare.Server.Pages.Children
{
    public partial class Create
    {
        [Inject]
        public ChildService ChildService { get; set; }
        [Inject]
        public AddressService AddressService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public Child NewChild { get; set; } = new Child();
        public List<Address> Addresses { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Addresses = await AddressService.GetAddressesAsync();
        }

        private async Task SaveChild()
        {
            await ChildService.AddChildAsync(NewChild);
        }

        private void NavigateToNewAddress()
        {
            // TODO: Create model to add a new address
        }

        private void NavigateBack()
        {
            navManager.NavigateTo("/children");
        }
    }
}
