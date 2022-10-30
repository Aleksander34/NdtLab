using AutoMapper;
using NdtLab.Core.Requests;
using NdtLab.Dto.EmployeesInfo;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Request), ReverseMap = true)]
    public class RequestDto
    {
        public PipingDto Piping { get; set; }

        public SteelStructureDto SteelStructure { get; set; }

        public TankDto Tank { get; set; }

        public PipeLineDto PipeLine { get; set; }

        public ReferencesDocDto ReferencesDoc { get; set; }

        public int DivisionId { get; set; }

        public QualificationDto Qualification { get; set; }

        public bool? Rebar { get; set; }

        public string WeldingCompany { get; set; }

        public string Object { get; set; }

        public string PartObject { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public string Draw { get; set; }

        public string CategoryGost { get; set; }

        public string OtherCategory { get; set; }
        public int? Temperature { get; set; }
    }
}
