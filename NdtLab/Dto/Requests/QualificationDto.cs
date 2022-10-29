using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Qualification), ReverseMap = true)]
    public class QualificationDto
    {
        public TypeQualification TypeQualification { get; set; }
    }
}
