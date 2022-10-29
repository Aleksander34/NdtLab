using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests.SteelStructureDto
{
    [AutoMap(typeof(SteelStructure), ReverseMap = true)]
    public class CreateSteelStructureDto
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
