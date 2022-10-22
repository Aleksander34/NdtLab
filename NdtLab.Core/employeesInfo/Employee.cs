using NdtLab.core.Inspections;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.employeesInfo
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public Division Division { get; set; }

        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public virtual ICollection<InspectionEmployee> InspectionEmployees { get; set; }
    }
}
