using NdtLab.Dto.EmployeesInfo;
using NdtLab.Dto.Inspections;
using NdtLab.Dto.Joints;
using NdtLab.Dto.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdtLab.ExcelParser
{
    public class ExcelInputDto
    {
        public RequestDto Request { get; set; }
        public List<JointDto> Joints { get; set; }
        public DivisionDto Division { get; set; }
        public InspectionDto Inspection { get; set; }
    }
}
