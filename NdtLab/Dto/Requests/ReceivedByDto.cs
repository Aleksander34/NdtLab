using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(ReceivedBy), ReverseMap = true)]
    public class ReceivedByDto: EntityDto    //TODO:?
    {
        public int EmployeeId { get; set; }
    }
}
