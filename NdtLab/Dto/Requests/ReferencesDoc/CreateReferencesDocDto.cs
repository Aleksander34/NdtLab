using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests.ReferencesDoc
{
    [AutoMap(typeof(ReferencesDoc), ReverseMap = true)]
    public class CreateReferencesDocDto
    {
        public string MainDoc { get; set; }
        /// <summary>
        /// Документ по сварке
        /// </summary>
        public string WeldingDoc { get; set; }
        /// <summary>
        /// Документ по инспекции
        /// </summary>
        public string InspectionDoc { get; set; }
        /// <summary>
        /// Документ по оценке качества
        /// </summary>
        public string QualityCriteria { get; set; }
    }
}
