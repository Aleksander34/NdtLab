using NdtLab.core;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.employeesInfo
{
    public class Phone: Entity
    {
        public string Number { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public override string ToString()
        {
            return $"{{ Номер: {Number}, IdПользователя: {EmployeeId}}}";
        }
    }
}
