using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Dto.Requests;

namespace NdtLab.Controllers.Requests
{
    public class RequestsController : NdtLabController
    {
        private readonly RequestsController _context;
        public RequestsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(CreateRequestDto input)
        {
            _context.Requests.Add(input.Request);
            _context.SaveChanges();
            foreach (var phoneNumber in input.PhoneNumbers)
            {
                _context.Phones.Add(new Phone
                {
                    UserId = input.Employee.Id,
                    Number = phoneNumber
                });
                _context.SaveChanges();
            }
            return Ok($"Сотрудник {input.Employee.Name} добавлен");
        }
    }
}
