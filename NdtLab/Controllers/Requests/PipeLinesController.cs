using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class PipeLinesController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public PipeLinesController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var pipeLines = _context.PipeLines.ToList();
            var result = _mapper.Map<IEnumerable<PipeLineDto>>(pipeLines);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(PipeLineDto input)
        {
            var pipeLine = _mapper.Map<PipeLine>(input);
            _context.PipeLines.Add(pipeLine);
            _context.SaveChanges();

            return Ok($"магистральный трубопровод {pipeLine.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var pipeLine = _context.PipeLines.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.PipeLines.Remove(pipeLine);
            _context.SaveChanges();
            return Ok($"магистральный трубопровод {pipeLine.Id} успешно удален ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(PipeLineDto input)
        {
            var pipeLine = _mapper.Map<PipeLine>(input);
            _context.PipeLines.Update(pipeLine);
            _context.SaveChanges();
            return Ok($"Трубопровод {pipeLine.Id} обновлен");
        }

    }
}
