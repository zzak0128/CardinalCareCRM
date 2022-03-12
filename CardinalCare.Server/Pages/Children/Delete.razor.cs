using System;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Service;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Server.Pages.Children
{
    public partial class Delete
    {
        [Inject]
        public ChildService ChildService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        public int id { get; set; }
        public Child ChildToDelete { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ChildToDelete = await ChildService.GetChildByIdAsync(id);
        }
        private async Task DeleteChild()
        {
            await ChildService.DeleteChildAsync(ChildToDelete);
            ReturnToAll();
        }

        private void CancelToDetails()
        {
            navManager.NavigateTo($"/Children/Details/{id}");
        }

        private void ReturnToAll()
        {
            navManager.NavigateTo("/Children");
        }
    }
}
