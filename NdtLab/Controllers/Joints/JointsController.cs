using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.core.Joints;
using NdtLab.Core;

namespace NdtLab.Controllers.Joints
{

    public class JointsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public JointsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Joint joint)
        {
            _context.Joints.Add(joint);
            _context.SaveChanges();
            return Ok($"Стык {joint} добавлен");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var joints = _context.Joints.ToList();
            return Ok(joints);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var joint = _context.Joints.Find(id);
            _context.Joints.Remove(joint);
            _context.SaveChanges();
            return Ok($"Стык {joint} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Joint joint)
        {
            _context.Joints.Update(joint);
            _context.SaveChanges();
            return Ok($"Стык {joint} обновлен");
        }
    }
}
