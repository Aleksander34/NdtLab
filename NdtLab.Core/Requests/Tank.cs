using NdtLab.core;

namespace NdtLab.Core.Requests;

public class Tank : Entity
{
    /// <summary>
    /// Часть резервуара
    /// </summary>
    public PartTank PartTank { get; set; }
    public override string ToString()
    {
        return $"{{ part: {PartTank}}}";
    }
}
