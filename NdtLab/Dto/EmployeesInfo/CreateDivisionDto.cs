using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Division), ReverseMap = true)]
    public class CreateDivisionDto
    {
        public string Name { get; set; }
    }
}
