using System;
using System.Collections.Generic;
using CardinalCare.Domain;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Pages.Workplaces
{
    public partial class Index
    {
        [Inject]
        public List<Workplace> AllWorkplaces { get; set; }
    }
}
