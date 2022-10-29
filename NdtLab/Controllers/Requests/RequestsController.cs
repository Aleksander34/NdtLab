using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;
using NdtLab.Dto.Requests.RequestDto;

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

        [HttpPost("[action]")]
        public IActionResult Create(CreateRequestDto input)
        {
            var request = _mapper.Map<Request>(input);
            _context.Requests.Add(request);
            _context.SaveChanges();
            
            return Ok($"Сотрудник {request} добавлен");
        }
    }
}
