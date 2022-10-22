using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        //[HttpGet("[action]")]
        //public IActionResult GetAll()
        //{
        //    var roles = _context.Roles.ToList();
        //    return Ok(roles);
        //}

        //[HttpPost("[action]")]
        //public IActionResult Remove(int id)
        //{
        //    var role = _context.Roles.Find(id);
        //    _context.Roles.Remove(role);
        //    _context.SaveChanges();
        //    return Ok($"Роль {role.Name} удалена");
        //}

        //[HttpPost("[action]")]
        //public IActionResult Update(Role role)
        //{
        //    _context.Roles.Update(role);
        //    _context.SaveChanges();
        //    return Ok($"Роль {role.Name} обновлена");
        //}
    }
}
