using System;
using CardinalCare.Domain.Attributes;

namespace CardinalCare.Domain.Interfaces
{
    public interface ISingleSelect
    {
        string Title { get; }

        int GetId();
    }
}
