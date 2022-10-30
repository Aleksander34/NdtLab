using NdtLab.core;

namespace NdtLab.Core.Requests;

public class Tank : Entity
{
    /// <summary>
    /// Часть резервуара
    /// </summary>
    public PartTank Part { get; set; }
    public override string ToString()
    {
        return $"{{ part: {Part}}}";
    }
}
