using NdtLab.Core.employeesInfo;

namespace NdtLab.Dto.EmployeesInfo
{
    public class CreateEmployeeDto
    {
        public Employee Employee { get; set; }
        public string[] PhoneNumbers { get; set; }
    }
}
