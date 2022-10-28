using AutoMapper;
using NdtLab.core.Joints;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(Joint), ReverseMap = true)]
    public class CreateJointsDto
    {
        public int RequestId { get; set; }
        public int ReestrId { get; set; }
        public string InspectionCompany { get; set; }
        public string Number { get; set; }
        public DateTime WeldingDate { get; set; }
        public string WeldingType { get; set; }
        public string ConnectionType { get; set; }
        public string ElementOne { get; set; }
        public string ElementTwo { get; set; }
        public string GradeOne { get; set; }
        public string GradeTwo { get; set; }
        public double ThicknessOne { get; set; }
        public double ThicknessTwo { get; set; }
        public double DiameterOne { get; set; }
        public double DiameterTwo { get; set; }
        public double? WeldLength { get; set; }
        public string? Status { get; set; }
        public string? Note { get; set; }
        public virtual ICollection<DifficultJoint> DifficultJoints { get; set; }   //????????
        public virtual ICollection<WelderJoint> WelderJoints { get; set; }         //????????
    }
}
