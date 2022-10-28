using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Role), ReverseMap = true)]
    public class CreateRoleDto
    {
        public string Name { get; set; }
    }
}
