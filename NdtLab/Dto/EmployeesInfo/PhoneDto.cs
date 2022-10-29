using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Phone), ReverseMap = true)]
    public class PhoneDto : EntityDto
    {
        public string Number { get; set; }
        public int EmployeeId { get; set; }
    }
}
