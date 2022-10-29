using AutoMapper;
using NdtLab.Core.Requests;

namespace NdtLab.Dto.Requests.RequestDto
{
    [AutoMap(typeof(Request), ReverseMap = true)]
    public class CreateRequestDto
    {
        public int? PipingId { get; set; }

        /// <summary>
        /// Металлоконструкции
        /// </summary>
        public int? SteelStructureId { get; set; }

        /// <summary>
        /// Резервуары
        /// </summary>
        public int? TankId { get; set; }

        /// <summary>
        /// Магистральный Трубопровод
        /// </summary>
        public int? PipeLineId { get; set; }

        /// <summary>
        /// НТД нормативные документы
        /// </summary>
        public int? ReferencesDocId { get; set; }

        /// <summary>
        /// Подразделение/Город
        /// </summary>
        public int DivisionId { get; set; }

        public int? QualificationId { get; set; }

        /// <summary>
        /// Арматура
        /// </summary>
        public bool? Rebar { get; set; }
        /// <summary>
        /// Компания производитель сварочных работ
        /// </summary>
        public string WeldingCompany { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Object { get; set; }
        /// <summary>
        /// Наименование части объекта
        /// </summary>
        public string PartObject { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Дата заявки
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Номер чертежа
        /// </summary>
        public string Draw { get; set; }
        /// <summary>
        /// Категория ГОСТ
        /// </summary>
        public string CategoryGOST { get; set; }
        /// <summary>
        /// Иная категория
        /// </summary>
        public string OtherCategory { get; set; }
        /// <summary>
        /// Температура эксплуатации
        /// </summary>
        public int? Temperature { get; set; }
    }
}
