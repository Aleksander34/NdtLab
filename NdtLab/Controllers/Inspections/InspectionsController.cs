using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.core.Inspections;
using NdtLab.Core;
using NdtLab.Dto.Inspections;

namespace NdtLab.Controllers.Inspections
{
    public class InspectionsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public InspectionsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var inspections = _context.Inspections.ToList();
            var result = _mapper.Map<IEnumerable<InspectionDto>>(inspections);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(InspectionDto input)
        {
            var inspection = _mapper.Map<Inspection>(input);
            _context.Inspections.Add(inspection);
            _context.SaveChanges();

            return Ok($"инспекция {inspection.Id} добавлена");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var inspection = _context.Inspections.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Inspections.Remove(inspection);
            _context.SaveChanges();
            return Ok($"Инспекция {inspection.Id} удалена ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(InspectionDto input)
        {
            var inspection = _mapper.Map<Inspection>(input);
            _context.Inspections.Update(inspection);
            _context.SaveChanges();
            return Ok($"Инспекция {inspection.Id} обновлена");
        }
    }
}
