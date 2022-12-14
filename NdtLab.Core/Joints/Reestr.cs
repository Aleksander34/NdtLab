using NdtLab.core;
using NdtLab.core.Joints;

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
        public virtual ICollection<Joint> Joints { get; set; }

        public override string ToString()
        {
            return $"{{ Дата: {Date}, Номер: {Number} Кто передал: {Sender}, Кто получил: {Recipient}}}";
        }
    }
}
