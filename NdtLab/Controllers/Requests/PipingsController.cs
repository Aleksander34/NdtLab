using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class PipingsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public PipingsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var pipings = _context.Pipings.ToList();
            var result = _mapper.Map<IEnumerable<PipingDto>>(pipings);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(PipingDto input)
        {
            var piping = _mapper.Map<Piping>(input);
            _context.Pipings.Add(piping);
            _context.SaveChanges();

            return Ok($"трубопроводы {piping.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var piping = _context.Pipings.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Pipings.Remove(piping);
            _context.SaveChanges();
            return Ok($"Характеристики трубопровода {piping.Id} успешно удалены ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(PipingDto input)
        {
            var piping = _mapper.Map<Piping>(input);
            _context.Pipings.Update(piping);
            _context.SaveChanges();
            return Ok($"Трубопровод {piping.Id} обновлен");
        }
    }
}
