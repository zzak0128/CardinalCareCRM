using System;
using CardinalCare.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CardinalCare.Server.Service;

namespace CardinalCare.Server.Pages.Guardians
{
    public partial class Index
    {
        [Inject]
        public GuardianService GuardianService { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }

        public List<Guardian> Guardians { get; set; } = new List<Guardian>();

        protected override async Task OnInitializedAsync()
        {
            Guardians = await GuardianService.GetGuardiansAsync();
        }

        private void NavigateToCreate()
        {
            NavManager.NavigateTo("/guardians/register");
        }

    }
}
