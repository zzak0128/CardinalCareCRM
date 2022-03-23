using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Services;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Children
{
    public partial class Details
    {
        [Inject]
        public ChildService ChildService { get; set; }

        public int Id { get; set; }
        public Child DetailChild { get; set; }


        protected override async Task OnInitializedAsync()
        {
            DetailChild = await ChildService.GetChildByIdAsync(Id);
        }
    }
}
