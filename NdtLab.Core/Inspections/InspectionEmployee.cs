using NdtLab.Core.employeesInfo;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.core.Inspections
{
    public class InspectionEmployee
    {
        public int InspectionId {get;set;}
        [ForeignKey("InspectionId")]
        public Inspection Inspection { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
