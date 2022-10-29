using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(PipeLine), ReverseMap = true)]
    public class PipelineDto
    {
        public string Distance { get; set; }
    }
}
