using AutoMapper;
using NdtLab.core.Welders;

namespace NdtLab.Dto.Welders
{
    [AutoMap(typeof(Welder), ReverseMap = true)]
    public class CreateWelderDto
    {
        public string FullName { get; set; }
        public string Stamp { get; set; }
        public virtual ICollection<WelderJoint> WelderJoints { get; set; }
    }
}
