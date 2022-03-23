using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Workplaces
{
    public partial class Index
    {
        [Inject] public WorkplaceService WorkService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public List<Workplace> AllWorkplaces { get; set; } = new List<Workplace>();

        protected override async Task OnInitializedAsync()
        {
            AllWorkplaces = await WorkService.GetWorkplacesAsync();
        }

        private void NavigateToCreate()
        {
            NavManager.NavigateTo("/workplaces/create");
        }

        private async Task DeleteWorkplace(Workplace workplace)
        {
            AllWorkplaces.Remove(workplace);
            await WorkService.DeleteWorkplaceAsync(workplace);
            StateHasChanged();
        }
    }
}
