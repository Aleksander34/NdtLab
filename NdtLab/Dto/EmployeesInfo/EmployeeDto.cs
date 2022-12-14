using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Employee), ReverseMap = true)]
    public class EmployeeDto : EntityDto
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<PhoneDto> Phones { get; set; }
        public int RoleId { get; set; }
        public int DivisionId { get; set; }
        public int PositionId { get; set; }

    }
}
