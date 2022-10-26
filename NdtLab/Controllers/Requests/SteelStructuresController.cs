﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

namespace NdtLab.Controllers.Requests
{
    public class SteelStructuresController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public SteelStructuresController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(SteelStructure steelStructure)
        {
            _context.SteelStructures.Add(steelStructure);
            _context.SaveChanges();
            return Ok($"Металлоконструкции {steelStructure} добавлены");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var steelStructures = _context.SteelStructures.ToList();
            return Ok(steelStructures);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var steelStructure = _context.SteelStructures.Find(id);
            _context.SteelStructures.Remove(steelStructure);
            _context.SaveChanges();
            return Ok($"Металлоконструкция {steelStructure} удалена");
        }

        [HttpPost("[action]")]
        public IActionResult Update(SteelStructure steelStructure)
        {
            _context.SteelStructures.Update(steelStructure);
            _context.SaveChanges();
            return Ok($"Металлоконструкции {steelStructure} обновлены");
        }
    }
}