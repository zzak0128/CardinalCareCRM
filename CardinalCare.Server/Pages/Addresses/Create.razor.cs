using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Service;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Server.Pages.Addresses
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
