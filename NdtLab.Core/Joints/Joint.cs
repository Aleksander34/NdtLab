using NdtLab.core.Inspections;
using NdtLab.core.Welders;
using NdtLab.Core.Joints;
using NdtLab.Core.Requests;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdtLab.core.Joints
{
    public class Joint : Entity
    {
        /// <summary>
        /// Id заявки
        /// </summary>
        public int RequestId { get; set; }
        [ForeignKey("RequestId")]
        public Request Request { get; set; }
        /// <summary>
        /// Id реестра
        /// </summary>
        public int ReestrId { get; set; }
        [ForeignKey("ReestrId")]
        public Reestr Reestr { get; set; }
        public string InspectionCompany { get; set; }
        public string Number { get; set; }
        public DateTime WeldingDate { get; set; }
        public string WeldingType { get; set; }
        public string ConnectionType { get; set; }
        public string ElementOne { get; set; }
        public string ElementTwo { get; set; }
        public string GradeOne { get; set; }
        public string GradeTwo { get; set; }
        /// <summary>
        /// толщина mm
        /// </summary>
        public double ThicknessOne { get; set; }
        public double ThicknessTwo { get; set; }
        public double DiameterOne { get; set; }
        public double DiameterTwo { get; set; }
        public double? WeldLength { get; set; }
        /// <summary>
        /// Статус текущих работ по стыку
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }
        public virtual ICollection<DifficultJoint>DifficultJoints { get; set; }
        public virtual ICollection<WelderJoint> WelderJoints { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }

        public override string ToString()
        {
            return $"{{ Id заявки: {RequestId}, Id реестра: {ReestrId} Контролирующая компания: {InspectionCompany}, Номер: {Number}, Дата сварки: {WeldingDate}, Тип сварки: {WeldingType}, Тип соединения: {ConnectionType}, Элемент 1: {ElementOne}, Элемент 2: {ElementTwo}" +
                $"Марка стали 1: {GradeOne}, Марка стали 2: {GradeTwo} Толщина 1: {ThicknessOne}, Толщина 2: {ThicknessTwo}, Диаметр 1: {DiameterOne}, Диаметр 2: {DiameterTwo}, Длина сварного шва: {WeldLength}, Статус: {Status}, Примечание: {Note}}}";
        }
    }
}
