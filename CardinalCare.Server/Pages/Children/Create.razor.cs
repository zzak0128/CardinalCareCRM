using System;
using Microsoft.AspNetCore.Components;
using CardinalCare.Server.Service;
using CardinalCare.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using CardinalCare.Model.Interface;

namespace CardinalCare.Server.Pages.Children
{
    public partial class Create
    {
        [Inject] public ChildService ChildService { get; set; }
        [Inject] public AddressService AddressService { get; set; }
        [Inject] public GuardianService GuardianService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public Child NewChild { get; set; } = new Child();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<IMultiListSelectable> SelectedGuardians { get; set; } = new List<IMultiListSelectable>();
        public List<IMultiListSelectable> NotSelectedGuardians { get; set; } = new List<IMultiListSelectable>();

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
            NavManager.NavigateTo("/address/create");
        }

        private void NavigateBack()
        {
            NavManager.NavigateTo("/children");
        }
    }
}
