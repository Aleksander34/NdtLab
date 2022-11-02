using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class SteelStructuresController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public SteelStructuresController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var steelStructures = _context.SteelStructures.ToList();
            var result = _mapper.Map<IEnumerable<SteelStructureDto>>(steelStructures);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(SteelStructureDto input)
        {
            var steelStructure = _mapper.Map<SteelStructure>(input);
            _context.SteelStructures.Add(steelStructure);
            _context.SaveChanges();

            return Ok($"Металлоконструкции {steelStructure.Id} добавлены");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var steelStructure = _context.SteelStructures.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.SteelStructures.Remove(steelStructure);
            _context.SaveChanges();
            return Ok($"Металлоконструкции {steelStructure.Id} успешно удалены ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(SteelStructureDto input)
        {
            var steelStructure = _mapper.Map<SteelStructure>(input);
            _context.SteelStructures.Update(steelStructure);
            _context.SaveChanges();
            return Ok($"Металлоконструкции {steelStructure.Id} обновлены");
        }
    }
}
