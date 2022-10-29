using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Role), ReverseMap = true)]
    public class RoleDto : EntityDto
    {
        public string Name { get; set; }
    }
}
