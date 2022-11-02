using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.core.Joints;
using NdtLab.Core;
using NdtLab.Dto.Joints;

namespace NdtLab.Controllers.Joints
{

    public class JointsController : NdtLabController
    {
        private readonly IMapper _mapper;
        private readonly NdtLabContext _context;
        public JointsController(NdtLabContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var joints = _context.Joints.ToList();
            var result = _mapper.Map<IEnumerable<JointDto>>(joints);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Create(JointDto input)
        {
            var joint = _mapper.Map<Joint>(input);
            _context.Joints.Add(joint);
            _context.SaveChanges();

            return Ok($"Стык {joint.Id} добавлен");
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var joint = _context.Joints.Find(id);
            _context.Joints.Remove(joint);
            _context.SaveChanges();
            return Ok($"Стык {joint.Id} удален");
        }

        [HttpPost("[action]")]
        public IActionResult Update(JointDto input)
        {
            var joint = _mapper.Map<Joint>(input);
            _context.Joints.Update(joint);
            _context.SaveChanges();
            return Ok($"Стык {joint.Id} обновлен");
        }
    }
}
