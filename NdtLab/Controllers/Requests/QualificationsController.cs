﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdtLab.Core;
using NdtLab.Core.Requests;

namespace NdtLab.Controllers.Requests
{
    public class QualificationsController : NdtLabController
    {
        private readonly NdtLabContext _context;
        public QualificationsController(NdtLabContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult Create(Qualification qualification)
        {
            _context.Qualifications.Add(qualification);
            _context.SaveChanges();
            return Ok($"Квалификация {qualification.Name} добавлена");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var qualifications = _context.Qualifications.ToList();
            return Ok(qualifications);
        }

        [HttpPost("[action]")]
        public IActionResult Remove(int id)
        {
            var qualification = _context.Qualifications.Find(id);
            _context.Qualifications.Remove(qualification);
            _context.SaveChanges();
            return Ok($"Квалификация {qualification.Name} удалена");
        }

        [HttpPost("[action]")]
        public IActionResult Update(Qualification qualification)
        {
            _context.Qualifications.Update(qualification);
            _context.SaveChanges();
            return Ok($"Квалификация {qualification.Name} обновлена");
        }
    }
}