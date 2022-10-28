using AutoMapper;
using NdtLab.core.Inspections;

namespace NdtLab.Dto.Inspections
{
    [AutoMap(typeof(Inspection), ReverseMap = true)]
    public class CreateInspectionEmployeeDto
    {
        public int InspectionId { get; set; }
        public int EmployeeId { get; set; }
    }
}
