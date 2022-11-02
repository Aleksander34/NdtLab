using AutoMapper;
using NdtLab.core.Inspections;
using NdtLab.Dto.EmployeesInfo;
using NdtLab.Dto.Joints;

namespace NdtLab.Dto.Inspections
{
    [AutoMap(typeof(Inspection), ReverseMap = true)]
    public class InspectionDto : EntityDto
    {
        public JointDto Joint { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportNumber { get; set; }
        public InspectionResult Result { get; set; }
        public string Description { get; set; }
    }
}
