using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

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

        [HttpPost("[action]")]
        public IActionResult Create(ReferencesDoc referencesDoc)
        {
            _context.ReferencesDocs.Add(referencesDoc);
            _context.SaveChanges();
            return Ok($"НТД {referencesDoc} добавлены");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var referencesDocs = _context.ReferencesDocs.ToList();
            return Ok(referencesDocs);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var referencesDoc = _context.ReferencesDocs.Find(id);
            _context.ReferencesDocs.Remove(referencesDoc);
            _context.SaveChanges();
            return Ok($"НТД {referencesDoc.Id} удалены");
        }

        [HttpPost("[action]")]
        public IActionResult Update(ReferencesDoc referencesDoc)
        {
            _context.ReferencesDocs.Update(referencesDoc);
            _context.SaveChanges();
            return Ok($"НТД {referencesDoc.Id} обновлен");
        }
    }
}
