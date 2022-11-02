using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class ReferencesDocController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public ReferencesDocController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var referencesDocs = _context.ReferencesDocs.ToList();
            var result = _mapper.Map<IEnumerable<ReferencesDocDto>>(referencesDocs);
            return Ok(result);
        }


        [HttpPost("[action]")]
        public IActionResult Create(ReferencesDocDto input)
        {
            var referencesDoc = _mapper.Map<ReferencesDoc>(input);
            _context.ReferencesDocs.Add(referencesDoc);
            _context.SaveChanges();

            return Ok($"Ссылочная документация {referencesDoc.Id} добавлена");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var referencesDoc = _context.ReferencesDocs.Find(id);  // а что если в пипинг будет несколько колонок с id. как искать именно в колонке id???
            _context.ReferencesDocs.Remove(referencesDoc);
            _context.SaveChanges();
            return Ok($"Ссылочная документация {referencesDoc.Id} успешно удалена ");
        }

        [HttpPost("[action]")]
        public IActionResult Update(ReferencesDocDto input)
        {
            var referencesDoc = _mapper.Map<ReferencesDoc>(input);
            _context.ReferencesDocs.Update(referencesDoc);
            _context.SaveChanges();
            return Ok($"Ссылочная документация {referencesDoc.Id} обновлена");
        }
    }
}
