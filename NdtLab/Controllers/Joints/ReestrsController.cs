using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Joints;
using NdtLab.Dto.Joints;

namespace NdtLab.Controllers.Joints
{
    public class ReestrsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public ReestrsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var reestrs = _context.Reestrs.ToList();
            var result = _mapper.Map<IEnumerable<ReestrDto>>(reestrs);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Create(ReestrDto input)
        {
            var reestr = _mapper.Map<Reestr>(input);
            _context.Reestrs.Add(reestr);
            _context.SaveChanges();

            return Ok($"Реестр {reestr.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var reestr = _context.Reestrs.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Reestrs.Remove(reestr);
            _context.SaveChanges();
            return Ok($"Реестр {reestr.Id} удален ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(ReestrDto input)
        {
            var reestr = _mapper.Map<Reestr>(input);
            _context.Reestrs.Update(reestr);
            _context.SaveChanges();
            return Ok($"Реестр {reestr.Id} обновлен");
        }
    }
}
