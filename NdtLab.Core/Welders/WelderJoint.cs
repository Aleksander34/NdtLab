using NdtLab.core.Joints;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.core.Welders
{
    public class WelderJoint
    {
        public int JointId { get; set; }
        public int WelderId { get; set; }
        [ForeignKey("WelderId")]
        public Welder Welder { get; set; }
        [ForeignKey("JointId")]
        public Joint Joint { get; set; }

    }
}
