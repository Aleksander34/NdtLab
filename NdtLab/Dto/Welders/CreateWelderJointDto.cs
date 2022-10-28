using AutoMapper;
using NdtLab.core.Welders;

namespace NdtLab.Dto.Welders
{
    [AutoMap(typeof(WelderJoint), ReverseMap = true)]
    public class CreateWelderJointDto
    {
        public int JointId { get; set; }
        public int WelderId { get; set; }
    }
}
