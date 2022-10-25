using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

namespace NdtLab.Controllers.Requests
{
    public class PipeLinesConroller : NdtLabController
    {
        private readonly NdtLabContext _context;
        public PipeLinesConroller(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(PipeLine pipeLine)
        {
            _context.PipeLines.Add(pipeLine);
            _context.SaveChanges();
            return Ok($"Магистральный трубопровод {pipeLine} добавлен");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var pipeLines = _context.PipeLines.ToList();
            return Ok(pipeLines);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var pipeLine = _context.PipeLines.Find(id);
            _context.PipeLines.Remove(pipeLine);
            _context.SaveChanges();
            return Ok($"Магистральный трубопровод {pipeLine} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(PipeLine pipeLine)
        {
            _context.PipeLines.Update(pipeLine);
            _context.SaveChanges();
            return Ok($"Магистральный трубопровод {pipeLine} обновлен");
        }

    }
}
