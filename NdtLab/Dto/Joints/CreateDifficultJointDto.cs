using AutoMapper;
using NdtLab.Core.Joints;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(DifficultJoint), ReverseMap = true)]
    public class CreateDifficultJointDto
    {
        public int DifficultId { get; set; }
        public int JointId { get; set; }
    }
}
