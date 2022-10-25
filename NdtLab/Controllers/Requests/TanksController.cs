using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

namespace NdtLab.Controllers.Requests
{

    public class TanksController : NdtLabController
    {
         private readonly NdtLabContext _context;
        public TanksController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Tank tank)
        {
            _context.Tanks.Add(tank);
            _context.SaveChanges();
            return Ok($"Резервуар {tank} добавлен");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var tanks = _context.Tanks.ToList();
            return Ok(tanks);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var tank = _context.Tanks.Find(id);
            _context.Tanks.Remove(tank);
            _context.SaveChanges();
            return Ok($"Резервуар {tank} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Tank tank)
        {
            _context.Tanks.Update(tank);
            _context.SaveChanges();
            return Ok($"Резервуар {tank} обновлен");
        }
    }
}
