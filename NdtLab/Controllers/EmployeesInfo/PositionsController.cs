using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.EmployeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{

    public class PositionsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public PositionsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public IActionResult Create(string name)
        {
            _context.Positions.Add(new Position { Name = name });
            _context.SaveChanges();
            return Ok($"Позиция {name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var positions = _context.Positions.ToList();
            var result = _mapper.Map<IEnumerable<PositionDto>>(positions);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var position = _context.Positions.Find(id);
            _context.Positions.Remove(position);
            _context.SaveChanges();
            return Ok($"Позиция {position.Name} удалена");
        }

        [HttpPost("[action]")]
        public IActionResult Update(PositionDto input)
        {
            var position = _mapper.Map<Position>(input);
            _context.Positions.Update(position);
            _context.SaveChanges();
            return Ok($"Позиция {position.Name} обновлена");
        }
    }
}
