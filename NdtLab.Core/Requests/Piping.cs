using NdtLab.core;
namespace NdtLab.Core.Requests
{
    public class Piping : Entity
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
