using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.EmployeesInfo;

namespace NdtLab.Controllers.EmployeesInfo
{

    public class RolesController : NdtLabController
    {
        private readonly NdtLabContext _context;
        private readonly IMapper _mapper;
        public RolesController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public IActionResult Create(string name)
        {
            _context.Roles.Add(new Role { Name = name });
            _context.SaveChanges();
            return Ok($"Роль {name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var roles = _context.Roles.ToList();
            var result = _mapper.Map<IEnumerable<RoleDto>>(roles);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return Ok($"Роль {role.Name} удалено");
        }

        [HttpPost("[action]")]
        public IActionResult Update(RoleDto input)
        {
            var role = _mapper.Map<Role>(input);
            _context.Roles.Update(role);
            _context.SaveChanges();
            return Ok($"Роль {role.Name} обновлено");
        }
    }
}
