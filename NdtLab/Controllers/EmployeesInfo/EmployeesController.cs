using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.EmployeesInfo;
using System.Collections;

namespace NdtLab.Controllers.EmployeesInfo
{
    public class EmployeesController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public EmployeesController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost("[action]")]
        public IActionResult Create(CreateEmployeeDto input)
        {
            var employee = _mapper.Map<Employee>(input);
            _context.Employees.Add(employee);
            _context.SaveChanges();

            foreach (var phoneNumber in input.PhoneNumbers)
            {
                _context.Phones.Add(new Phone
                {
                    EmployeeId = employee.Id,
                    Number = phoneNumber
                });
                _context.SaveChanges();
            }
            return Ok($"Сотрудник {input.Name} добавлен");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var employees = _context.Employees.Include(x => x.Phones).ToList();
            var result = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return Ok(result);
        }



        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok($"Сотрудник {employee.Name} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(EmployeeDto input)
        {
            var employee = _mapper.Map<Employee>(input);
            employee.Phones = null;
            _context.Employees.Update(employee);
            _context.SaveChanges();

            var phones = _context.Phones.Where(x => x.EmployeeId == input.Id).ToList();
            foreach (var p in phones)
            {
                _context.Phones.Remove(p);
            }
            _context.SaveChanges();
            foreach (var phone in input.Phones)
            {
                _context.Phones.Add(new Phone
                {
                    EmployeeId = employee.Id,
                    Number = phone.Number
                });
                _context.SaveChanges();
            }
            return Ok($"Сотрудник {input.Name} обновлен");
        }
    }
}
