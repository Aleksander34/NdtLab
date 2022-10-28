using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Position), ReverseMap = true)]
    public class CreatePositionDto
    {
        public string Name { get; set; }
    }
}
