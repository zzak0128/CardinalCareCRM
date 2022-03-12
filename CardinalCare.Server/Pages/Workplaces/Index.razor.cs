using System;
using System.Collections.Generic;
using CardinalCare.Model;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Server.Pages.Workplaces
{
    public partial class Index
    {
        [Inject]
        public List<Workplace> AllWorkplaces { get; set; }
    }
}
