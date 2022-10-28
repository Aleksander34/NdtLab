using AutoMapper;
using NdtLab.core.Inspections;

namespace NdtLab.Dto.Inspections
{
    [AutoMap(typeof(Inspection), ReverseMap = true)]
    public class CreateInspectionDto
    {
        public int JointId { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportNumber { get; set; }
        public InspectionResult Result { get; set; }
        public string Description { get; set; }
        public virtual ICollection<InspectionEmployee> InspectionEmployees { get; set; }   //??
    }
}
