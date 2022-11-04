using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NdtLab.Core;
using NdtLab.Core.employeesInfo;
using NdtLab.Dto.Account;
using NdtLab.Dto.EmployeesInfo;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NdtLab.Controllers
{
    public class AccountController : NdtLabController
    {
        private readonly NdtLabContext _context;

        private readonly IMapper _mapper;
        public AccountController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public IActionResult Login(AccountInput input)
        {
            string token = GetToken(input.Login, input.Password);
            return Ok(token);
        }

        private string GetToken(string login, string password)
        {
            ClaimsIdentity identity = GetIdentity(login, password);
            if (identity == null)
            {
                throw new Exception("Неправильно введен логин или пароль");
            }
            var nowTime = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: "NdtLabxxx",
                audience: "NdtLabWebxxx",
                notBefore: nowTime,
                expires: nowTime.AddHours(10),
                claims: identity.Claims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes("asdfghjkl123456j")), SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        private ClaimsIdentity GetIdentity(string login, string password)
        {
            var employee = _context.Employees.Include(x=>x.Role).SingleOrDefault(x => x.Login == login && x.Password == password);
            if (employee == null)
            {
                return null;
            }

            var claims = new List<Claim>() 
            { 
                new Claim(ClaimsIdentity.DefaultNameClaimType, employee.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, employee.Role.Name)
            };
            return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }

        [HttpPost("[action]")]
        public IActionResult Registration(EmployeeDto input)  //потом расшитрить больше информации информация фио подразделение
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Login == input.Login && e.Password == input.Password);
            if (employee != null)
            {
                return BadRequest("Аккаунт занят");
            }
            employee = _mapper.Map<Employee>(input);
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok("Аккаунт успешно создан");
        }
    }
}
