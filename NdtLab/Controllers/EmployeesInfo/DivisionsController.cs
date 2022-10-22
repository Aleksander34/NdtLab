using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{
    public class DivisionsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public DivisionsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Division division)
        {
            _context.Divisions.Add(division);
            _context.SaveChanges();
            return Ok($"Подразделение {division.Name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var divisions = _context.Divisions.ToList();
            return Ok(divisions);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var division = _context.Divisions.Find(id);
            _context.Divisions.Remove(division);
            _context.SaveChanges();
            return Ok($"Подразделение {division.Name} удалено");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Division division)
        {
            _context.Divisions.Update(division);
            _context.SaveChanges();
            return Ok($"Подразделение {division.Name} обновлено");
        }
    }
}
