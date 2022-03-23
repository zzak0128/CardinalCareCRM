using System;
using Microsoft.AspNetCore.Components;
using CardinalCare.Infrastructure.Services;
using CardinalCare.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;
using CardinalCare.Domain.Interfaces;

namespace CardinalCare.Web.Blazor.Pages.Guardians
{
    public partial class Create
    {
        [Inject] public AddressService AddressService { get; set; }
        [Inject] public GuardianService GuardianService { get; set; }
        [Inject] public WorkplaceService WorkplaceService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public Guardian NewGuardian { get; set; } = new Guardian();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public ISingleSelect SelectedAddress { get; set; } = new Address();
        public List<Workplace> Workplaces { get; set; } = new List<Workplace>();
        public ISingleSelect SelectedWorkplace { get; set; } = new Workplace();

        protected override async Task OnInitializedAsync()
        {
            Addresses = await AddressService.GetAddressesAsync();
            Workplaces = await WorkplaceService.GetWorkplacesAsync();
        }

        private async Task SaveGuardian()
        {
            NewGuardian.Address = SelectedAddress as Address;
            NewGuardian.Workplace = SelectedWorkplace as Workplace;
            await GuardianService.AddGuardianAsync(NewGuardian);
        }

        private void NavigateToNewAddress()
        {
            // TODO: Create model to add a new address
            NavManager.NavigateTo("/address/create");
        }

        private void NavigateToNewWorkplace()
        {
            NavManager.NavigateTo("/workplaces/create");
        }

        private void NavigateBack()
        {
            NavManager.NavigateTo("/guardians");
        }
    }
}
