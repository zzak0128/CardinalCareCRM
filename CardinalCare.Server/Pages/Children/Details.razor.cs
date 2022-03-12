using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Service;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Server.Pages.Children
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
