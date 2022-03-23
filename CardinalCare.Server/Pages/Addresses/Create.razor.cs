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
        [Inject]
        public AddressService AddressService { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

        protected override async Task OnParametersSetAsync()
        {
            Addresses = await AddressService.GetAddressesAsync();
        }
    }
}
