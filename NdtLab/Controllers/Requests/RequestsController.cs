using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class RequestsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public RequestsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var requests = _context.Requests.ToList();
            var result = _mapper.Map<IEnumerable<RequestDto>>(requests);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Create(RequestDto input)
        {
            var request = _mapper.Map<Request>(input);
            _context.Requests.Add(request);
            _context.SaveChanges();
            
            return Ok($"Заяка {request.Id} добавлена");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var request = _context.Requests.Find(id);
            _context.Requests.Remove(request);
            _context.SaveChanges();
            return Ok($"Заявка {request.Id} удалена");
        }

        [HttpGet("[action]")]
        public IActionResult Update(RequestDto input)
        {
            var request = _mapper.Map<Request>(input);
            _context.Requests.Update(request);
            _context.SaveChanges();
            return Ok($"Заяка {request.Id} обновлена");
        }
    }
}
