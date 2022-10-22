using Microsoft.EntityFrameworkCore;
using NdtLab.core.Joints;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.Core.Joints
{
    public class DifficultJoint
    {
        public int DifficultId { get; set; }
        [ForeignKey("DifficultId")]
        public Difficult Difficult { get; set; }
        public int JointId { get; set; }
        [ForeignKey("JointId")]
        public Joint Joint { get; set; }
    }
}
