using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.EmployeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{
    public class DivisionsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public DivisionsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public IActionResult Create(string name)
        {
            _context.Divisions.Add(new Division {Name=name});
            _context.SaveChanges();
            return Ok($"Подразделение {name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var divisions = _context.Divisions.ToList();
            var result = _mapper.Map<IEnumerable<DivisionDto>>(divisions);
            return Ok(result);
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
        public IActionResult Update(DivisionDto input)
        {
            var division = _mapper.Map<Division>(input);
            _context.Divisions.Update(division);
            _context.SaveChanges();
            return Ok($"Подразделение {division.Name} обновлено");
        }
    }
}
