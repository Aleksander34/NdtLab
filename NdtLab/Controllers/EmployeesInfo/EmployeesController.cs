using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.EmployeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{
    public class EmployeesController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public EmployeesController(NdtLabContext context)
        {
            _context = context;
        }


        [HttpPost("[action]")]
        public IActionResult Create(CreateEmployeeDto input)
        {
            _context.Employees.Add(input.Employee);
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

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var employees = _context.Employees.Include(x => x.Phones).ToList();
            return Ok(employees);
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
        public IActionResult Update(CreateEmployeeDto input)
        {
            _context.Employees.Update(input.Employee);
            var phones = _context.Phones.Where(x => x.UserId == input.Employee.Id).ToList();
            foreach (var p in phones)
            {
                _context.Phones.Remove(p);
            }
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
            return Ok($"Сотрудник {input.Employee.Name} обновлен");
        }
    }
}
