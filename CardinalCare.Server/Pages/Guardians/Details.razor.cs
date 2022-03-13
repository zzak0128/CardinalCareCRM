using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Service;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Server.Pages.Guardians
{
    public partial class Details
    {
        [Inject]
        public GuardianService GuardianService { get; set; }

        public int Id { get; set; }
        public Guardian DetailGuardian { get; set; }


        protected override async Task OnInitializedAsync()
        {
            DetailGuardian = await GuardianService.GetGuardianByIdAsync(Id);
        }
    }
}
