using NdtLab.core;
namespace NdtLab.Core.Requests;

public class ReferencesDoc : Entity
{
    /// <summary>
    /// Основной документ
    /// </summary>
    public string MainDoc { get; set; }
    /// <summary>
    /// Документ по сварке
    /// </summary>
    public string WeldingDoc { get; set; }
    /// <summary>
    /// Документ по инспекции
    /// </summary>
    public string InspectionDoc { get; set; }
    /// <summary>
    /// Документ по оценке качества
    /// </summary>
    public string QualityCriteria { get; set; }
    public virtual ICollection<Request> Requests { get; set; }

    public override string ToString()
    {
        return $"{{ mainDoc: {MainDoc}, weldingDoc: {WeldingDoc}, inspectionDoc: {InspectionDoc}, qualityCriteria: {QualityCriteria}}}";
    }

}
