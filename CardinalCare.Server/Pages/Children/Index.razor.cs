using System;
using CardinalCare.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CardinalCare.Server.Service;

namespace CardinalCare.Server.Pages.Children
{
    public partial class Index
    {
        [Inject]
        public ChildService ChildService { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }

        public List<Child> Children { get; set; } = new List<Child>();

        protected override async Task OnInitializedAsync()
        {
            Children = await ChildService.GetChildrenListAsync();
        }

        private void NavigateToCreate()
        {
            NavManager.NavigateTo("/children/register");
        }

    }
}
