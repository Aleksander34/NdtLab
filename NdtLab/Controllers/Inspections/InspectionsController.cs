using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.core.Inspections;
using NdtLab.Core;

namespace NdtLab.Controllers.Inspections
{
    public class InspectionsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public InspectionsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Inspection inspection)
        {
            _context.Inspections.Add(inspection);
            _context.SaveChanges();
            return Ok($"Инспекция {inspection} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var inspections = _context.Inspections.ToList();
            return Ok(inspections);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var inspection = _context.Inspections.Find(id);
            _context.Inspections.Remove(inspection);
            _context.SaveChanges();
            return Ok($"Инспекция {inspection} удалена");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Inspection inspection)
        {
            _context.Inspections.Update(inspection);
            _context.SaveChanges();
            return Ok($"Инспекция {inspection} обновлена");
        }
    }
}
