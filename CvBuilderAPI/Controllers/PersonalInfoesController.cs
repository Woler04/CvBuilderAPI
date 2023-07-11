using System;
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
    public class PersonalInfoesController : ControllerBase
    {
        private readonly CvAPIDbContext _context;

        public PersonalInfoesController(CvAPIDbContext context)
        {
            _context = context;
        }

        // GET: api/PersonalInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalInfo>>> GetPesronalInfos()
        {
          if (_context.PesronalInfos == null)
          {
              return NotFound();
          }
            return await _context.PesronalInfos.ToListAsync();
        }

        // GET: api/PersonalInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalInfo>> GetPersonalInfo(int id)
        {
          if (_context.PesronalInfos == null)
          {
              return NotFound();
          }
            var personalInfo = await _context.PesronalInfos.FindAsync(id);

            if (personalInfo == null)
            {
                return NotFound();
            }

            return personalInfo;
        }

        // PUT: api/PersonalInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalInfo(int id, PersonalInfo personalInfo)
        {
            if (id != personalInfo.PersonalinfoId)
            {
                return BadRequest();
            }

            _context.Entry(personalInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalInfoExists(id))
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

        // POST: api/PersonalInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonalInfo>> PostPersonalInfo(PersonalInfo personalInfo)
        {
          if (_context.PesronalInfos == null)
          {
              return Problem("Entity set 'CvAPIDbContext.PesronalInfos'  is null.");
          }
            _context.PesronalInfos.Add(personalInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalInfo", new { id = personalInfo.PersonalinfoId }, personalInfo);
        }

        // DELETE: api/PersonalInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalInfo(int id)
        {
            if (_context.PesronalInfos == null)
            {
                return NotFound();
            }
            var personalInfo = await _context.PesronalInfos.FindAsync(id);
            if (personalInfo == null)
            {
                return NotFound();
            }

            _context.PesronalInfos.Remove(personalInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalInfoExists(int id)
        {
            return (_context.PesronalInfos?.Any(e => e.PersonalinfoId == id)).GetValueOrDefault();
        }
    }
}
