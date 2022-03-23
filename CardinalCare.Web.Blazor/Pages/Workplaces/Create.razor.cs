using System;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Workplaces
{
    public partial class Create
    {
        [Inject] public WorkplaceService WorkService { get; set; }
        [Inject] public NavigationManager NavManager { get; set; }

        public Workplace NewWorkplace { get; set; } = new Workplace();

        //protected override async Task OnParameterSetAsync()
        //{
        //}

        private async Task SaveWorkplaceAsync()
        {
            NewWorkplace.Title = $"{NewWorkplace.Name} @ {NewWorkplace.City}";
            await WorkService.AddWorkplaceAsync(NewWorkplace);
            NavigateBack();
        }

        private void NavigateBack()
        {
            NavManager.NavigateTo("/workplaces");
        }
    }
}
