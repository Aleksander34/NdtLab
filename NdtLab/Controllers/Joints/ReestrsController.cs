using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Joints;

namespace NdtLab.Controllers.Joints
{
    public class ReestrsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public ReestrsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Reestr reestr)
        {
            _context.Reestrs.Add(reestr);
            _context.SaveChanges();
            return Ok($"Реестр {reestr} добавлен");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var reestrs = _context.Reestrs.ToList();
            return Ok(reestrs);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var reestr = _context.Reestrs.Find(id);
            _context.Reestrs.Remove(reestr);
            _context.SaveChanges();
            return Ok($"Реестр {reestr.Id} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Reestr reestr)
        {
            _context.Reestrs.Update(reestr);
            _context.SaveChanges();
            return Ok($"Реестр {reestr.Id} обновлен");
        }
    }
}
