using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Joints;
using NdtLab.Dto.Joints;

namespace NdtLab.Controllers.Joints
{
    public class DifficultsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public DifficultsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var difficults = _context.Difficults.ToList();
            var result = _mapper.Map<IEnumerable<DifficultDto>>(difficults);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(DifficultDto input)
        {
            var difficult = _mapper.Map<Difficult>(input);
            _context.Difficults.Add(difficult);
            _context.SaveChanges();
            return Ok($"препятствие {difficult.Id} добавлено");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var difficult = _context.Difficults.Find(id); 
            _context.Difficults.Remove(difficult);
            _context.SaveChanges();
            return Ok($"Препятствие {difficult.Id} удалены ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(DifficultDto input)
        {
            var difficult = _mapper.Map<Difficult>(input);
            _context.Difficults.Update(difficult);
            _context.SaveChanges();
            return Ok($"Препятствие {difficult.Id} обновлено");
        }

    }
}
