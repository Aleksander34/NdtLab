using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(SteelStructure), ReverseMap = true)]
    public class SteelStructureDto : EntityDto
    {
        public string Part { get; set; }

        public string Sector { get; set; }
    }
}
