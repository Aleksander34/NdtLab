using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{

    public class RolesController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public RolesController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return Ok($"Роль {role.Name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var roles = _context.Roles.ToList();
            return Ok(roles);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return Ok($"Роль {role.Name} удалена");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return Ok($"Роль {role.Name} обновлена");
        }
    }
}
