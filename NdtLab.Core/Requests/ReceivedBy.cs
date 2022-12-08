using NdtLab.Core.employeesInfo;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.Requests
{
    public class ReceivedBy
    {
        public int EmployeeId { get; set; } //TODO:?
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
