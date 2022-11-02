using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class QualificationsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public QualificationsController(NdtLabContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var qualifications = _context.Qualifications.ToList();
            var result = _mapper.Map<IEnumerable<QualificationDto>>(qualifications);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(QualificationDto input)
        {
            var qualification = _mapper.Map<Qualification>(input);
            _context.Qualifications.Add(qualification);
            _context.SaveChanges();

            return Ok($"Квалификация {qualification.Id} добавлена");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var qualification = _context.Qualifications.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Qualifications.Remove(qualification);
            _context.SaveChanges();
            return Ok($"Квалификация {qualification.Id} успешно удалена ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(QualificationDto input)
        {
            var qualification = _mapper.Map<Qualification>(input);
            _context.Qualifications.Update(qualification);
            _context.SaveChanges();
            return Ok($"Квалификация {qualification.Id} обновлена");
        }
    }
}
