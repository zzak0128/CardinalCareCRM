using System.Collections.Generic;
using CardinalCare.Domain.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CardinalCare.Web.Blazor.Components
{
    public partial class SingleSelect
    {

        [Parameter] public string ItemName { get; set; }
        [Parameter] public IEnumerable<ISingleSelect> Items { get; set; } = new List<ISingleSelect>();
        [Parameter] public ISingleSelect SelectedItem { get; set; }

        [Parameter] public EventCallback<ISingleSelect> SelectedItemChanged { get; set; }

        private void Select(ISingleSelect item)
        {
            Deselect();
            SelectedItem = item;
        }

        private void Deselect()
        {
            SelectedItem = null;
        }

    }
}
