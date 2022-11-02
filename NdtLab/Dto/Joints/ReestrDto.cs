using AutoMapper;
using NdtLab.Core.Joints;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(Reestr), ReverseMap = true)]
    public class ReestrDto : EntityDto
    {
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
    }
}
