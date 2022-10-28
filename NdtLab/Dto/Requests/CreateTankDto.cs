using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Tank), ReverseMap = true)]
    public class CreateTankDto
    {
        public PartTank PartTank { get; set; }
    }
}
