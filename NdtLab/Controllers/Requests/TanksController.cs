using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{

    public class TanksController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public TanksController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var tanks = _context.Tanks.ToList();
            var result = _mapper.Map<IEnumerable<TankDto>>(tanks);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(TankDto input)
        {
            var tank = _mapper.Map<Tank>(input);
            _context.Tanks.Add(tank);
            _context.SaveChanges();

            return Ok($"Характеристики резервуара {tank.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var tank = _context.Tanks.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.Tanks.Remove(tank);
            _context.SaveChanges();
            return Ok($"Характеристики резервуара {tank.Id} успешно удалены ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(TankDto input)
        {
            var tank = _mapper.Map<Tank>(input);
            _context.Tanks.Update(tank);
            _context.SaveChanges();
            return Ok($"Характеристики резервуара {tank.Id} обновлены");
        }
    }
}
