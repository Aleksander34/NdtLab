using NdtLab.core.Joints;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.core.Inspections
{
    public class Inspection : Entity
    {
        /// <summary>
        /// номер стыка
        /// </summary>
        public int JointId { get; set; }
        [ForeignKey("JointId")]
        public Joint Joint { get; set; }
        /// <summary>
        /// Метод контроля
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// необходимость контроля
        /// </summary>
        public bool IsRequired { get; set; }
        /// <summary>
        /// Дата контроля
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Дата заключения
        /// </summary>
        public DateTime ReportDate { get; set; }
        /// <summary>
        /// Номер заключения
        /// </summary>
        public string ReportNumber { get; set; }
        /// <summary>
        /// Результат контроля
        /// </summary>
        public InspectionResult Result { get; set; }
        /// <summary>
        /// Описание дефектов
        /// </summary>
        public string Description { get; set; }
        public virtual ICollection<InspectionEmployee> InspectionEmployees { get; set; }

        public override string ToString()
        {
            return $"{{ Id Стыка: {JointId}, Вид: {Name} Требуется да/нет: {IsRequired}, Дата: {Date}, дата заключения {ReportDate}, Номер заключения{ReportNumber}, результат {Result}, Описание дефектов {Description}}}";
        }
    }
}
