using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.core.Welders;
using NdtLab.Core;
using NdtLab.Dto.Welders;

namespace NdtLab.Controllers.Welders
{

    public class WeldersController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public WeldersController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var welders = _context.Welders.ToList();
            var result = _mapper.Map<IEnumerable<WelderDto>>(welders);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(WelderDto input)
        {
            var welder = _mapper.Map<Welder>(input);
            _context.Welders.Add(welder);
            _context.SaveChanges();
            return Ok($"Сварщик {welder.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var welder = _context.Welders.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Welders.Remove(welder);
            _context.SaveChanges();
            return Ok($"Сварщик {welder.Id} удален ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(WelderDto input)
        {
            var welder = _mapper.Map<Welder>(input);
            _context.Welders.Update(welder);
            _context.SaveChanges();
            return Ok($"Сварщик {welder.Id} обновлен");
        }
    }
}
