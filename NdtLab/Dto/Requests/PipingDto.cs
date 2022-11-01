using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Piping), ReverseMap = true)]
    public class PipingDto : EntityDto
    {
        public string Zone { get; set; }

        public string Line { get; set; }

        public string Spool { get; set; }
    }
}
