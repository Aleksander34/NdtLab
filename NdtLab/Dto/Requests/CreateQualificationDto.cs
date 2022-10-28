using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Qualification), ReverseMap = true)]
    public class CreateQualificationDto
    {
        public TypeQualification TypeQualification { get; set; }
    }
}
