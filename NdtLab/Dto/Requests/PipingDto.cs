using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(Piping), ReverseMap = true)]
    public class PipingDto : EntityDto
    {
        /// <summary>
        /// Номер зоны
        /// </summary>
        public string Zone { get; set; }
        /// <summary>
        /// Номер линии
        /// </summary>
        public string Line { get; set; }
        /// <summary>
        /// Номер спула/участка 
        /// </summary>
        public string Spool { get; set; }
    }
}
