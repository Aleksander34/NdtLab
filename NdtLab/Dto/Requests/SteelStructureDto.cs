using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests
{
    [AutoMap(typeof(SteelStructure), ReverseMap = true)]
    public class SteelStructureDto : EntityDto
    {
        /// <summary>
        /// Номер узла металлоконструкции
        /// </summary>
        public string Part { get; set; }
        /// <summary>
        /// Номер сектора металлоконструкции
        /// </summary>
        public string Sector { get; set; }
    }
}
