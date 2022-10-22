using NdtLab.core;

namespace NdtLab.Core.Joints
{
    public class Reestr : Entity
    {
        public DateTime Date { get; set; }
        public string Number { get; set; }
        /// <summary>
        /// кто  передал
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// Кто получил
        /// </summary>
        public string Recipient { get; set; }
    }
}
