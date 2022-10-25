using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

namespace NdtLab.Controllers.Requests
{
    public class PipingsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public PipingsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Piping piping)
        {
            _context.Pipings.Add(piping);
            _context.SaveChanges();
            return Ok($"Характеристики трубопровода {piping} успешно созданы ");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var pipings = _context.Pipings.ToList();
            return Ok($"Характеристики трубопроводов {pipings} успешно возвращены");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var piping = _context.Pipings.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Pipings.Remove(piping);
            _context.SaveChanges();
            return Ok($"Характеристики трубопровода {piping.Id} {piping.Zone} {piping.Line} успешно удалены ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Piping piping)
        {
            _context.Pipings.Update(piping);
            _context.SaveChanges();
            return Ok($"Характеристики трубопровода {piping} успешно обновлены ");
        }
    }
}
