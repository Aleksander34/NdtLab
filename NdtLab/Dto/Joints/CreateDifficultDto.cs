using AutoMapper;
using NdtLab.Core.Joints;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(Difficult), ReverseMap = true)]
    public class CreateDifficultDto
    {
        public string Name { get; set; }
        public virtual ICollection<DifficultJoint> DifficultJoints { get; set; }
    }
}
