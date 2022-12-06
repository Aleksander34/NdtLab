using AutoMapper;
using NdtLab.core.Joints;
using NdtLab.core.Welders;
using NdtLab.Core.Joints;
using NdtLab.Dto.Requests;
using NdtLab.Dto.Welders;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(Joint), ReverseMap = true)]
    public class JointDto : EntityDto
    {
        public RequestDto Request  { get; set; }
        public ReestrDto Reestr { get; set; }
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
        public string Status { get; set; }
        public string Note { get; set; }
        public ICollection<DifficultDto> Difficults { get; set; }
        public ICollection<WelderDto> Welders { get; set; }
        public string Stamps { get; set; }
        public string RequiredInspection { get; set; }
    }
}
