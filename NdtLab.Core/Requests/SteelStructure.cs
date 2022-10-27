using NdtLab.core;
namespace NdtLab.Core.Requests
{
    public class SteelStructure : Entity
    {
        /// <summary>
        /// Номер узла металлоконструкции
        /// </summary>
        public string Part { get; set; }
        /// <summary>
        /// Номер сектора металлоконструкции
        /// </summary>
        public string Sector { get; set; }

        public override string ToString()
        {
            return $"{{ part: {Part}, sector: {Sector}}}";
        }
    }
}
