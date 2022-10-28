using AutoMapper;
using NdtLab.Core.Joints;

namespace NdtLab.Dto.Joints
{
    [AutoMap(typeof(Reestr), ReverseMap = true)]
    public class CreateReestrDto
    {
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
    }
}
