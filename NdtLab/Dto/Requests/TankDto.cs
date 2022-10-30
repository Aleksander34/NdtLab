using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Tank), ReverseMap = true)]
    public class TankDto : EntityDto
    {
        public PartTank Part { get; set; }
    }
}
