﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CvBuilderAPI.Data;
using CvBuilderAPI.Models;

namespace CvBuilderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly CvAPIDbContext _context;

        public ExperiencesController(CvAPIDbContext context)
        {
            _context = context;
        }

        // GET: api/Experiences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperiences()
        {
          if (_context.Experiences == null)
          {
              return NotFound();
          }
            return await _context.Experiences.ToListAsync();
        }

        // GET: api/Experiences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Experience>> GetExperience(int id)
        {
          if (_context.Experiences == null)
          {
              return NotFound();
          }
            var experience = await _context.Experiences.FindAsync(id);

            if (experience == null)
            {
                return NotFound();
            }

            return experience;
        }

        // PUT: api/Experiences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExperience(int id, Experience experience)
        {
            if (id != experience.ExperienceId)
            {
                return BadRequest();
            }

            _context.Entry(experience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Experiences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Experience>> PostExperience(Experience experience)
        {
          if (_context.Experiences == null)
          {
              return Problem("Entity set 'CvAPIDbContext.Experiences'  is null.");
          }
            _context.Experiences.Add(experience);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExperience", new { id = experience.ExperienceId }, experience);
        }

        // DELETE: api/Experiences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperience(int id)
        {
            if (_context.Experiences == null)
            {
                return NotFound();
            }
            var experience = await _context.Experiences.FindAsync(id);
            if (experience == null)
            {
                return NotFound();
            }

            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExperienceExists(int id)
        {
            return (_context.Experiences?.Any(e => e.ExperienceId == id)).GetValueOrDefault();
        }
    }
}
