﻿using System;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Guardians
{
    public partial class Delete
    {
        [Inject]
        public GuardianService GuardianService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public int id { get; set; }
        public Guardian GuardianToDelete { get; set; }

        protected override async Task OnInitializedAsync()
        {
            GuardianToDelete = await GuardianService.GetGuardianByIdAsync(id);
        }
        private async Task DeleteGuardian()
        {
            await GuardianService.DeleteGuardianAsync(GuardianToDelete);
            ReturnToAll();
        }

        private void CancelToDetails()
        {
            navManager.NavigateTo($"/guardians/details/{id}");
        }

        private void ReturnToAll()
        {
            navManager.NavigateTo("/guardians");
        }
    }
}