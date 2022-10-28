using NdtLab.core;

namespace NdtLab.Core.Joints
{
    public class Difficult : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<DifficultJoint> DifficultJoints { get; set; }

        public override string ToString()
        {
            return $"{{ Трудности/Ограничения: {Name}}}";
        }
    }
}
