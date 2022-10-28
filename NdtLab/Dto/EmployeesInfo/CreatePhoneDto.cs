using AutoMapper;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    [AutoMap(typeof(Phone), ReverseMap = true)]
    public class CreatePhoneDto
    {
        public string Number { get; set; }
        public int UserId { get; set; }
    }
}
