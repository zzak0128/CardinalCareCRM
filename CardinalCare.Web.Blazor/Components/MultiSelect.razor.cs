﻿using System.Collections.Generic;
using CardinalCare.Domain.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Components
{
    public partial class MultiSelect
    {
        
        [Parameter] public string ItemName { get; set; }
        [Parameter] public List<IMultiListSelectable> NotSelected { get; set; } = new List<IMultiListSelectable>();
        [Parameter] public List<IMultiListSelectable> Selected { get; set; } = new List<IMultiListSelectable>();


        private void Select(IMultiListSelectable item)
        {
            NotSelected.Remove(item);
            Selected.Add(item);
        }

        private void Deselect(IMultiListSelectable item)
        {
            Selected.Remove(item);
            NotSelected.Add(item);
        }
    }
}