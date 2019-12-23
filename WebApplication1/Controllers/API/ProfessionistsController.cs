using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionistsController : ControllerBase
    {
        private readonly NoNullProjectContext _context;

        public ProfessionistsController(NoNullProjectContext context)
        {
            _context = context;
        }

        // GET: api/Professionists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professionist>>> GetProfessionists()
        {
            return await _context.Professionists.ToListAsync();
        }

        // GET: api/Professionists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Professionist>> GetProfessionist(int id)
        {
            var professionist = await _context.Professionists.FindAsync(id);

            if (professionist == null)
            {
                return NotFound();
            }

            return professionist;
        }

        // PUT: api/Professionists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionist(int id, Professionist professionist)
        {
            if (id != professionist.ProfId)
            {
                return BadRequest();
            }

            _context.Entry(professionist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionistExists(id))
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

        // POST: api/Professionists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Professionist>> PostProfessionist(Professionist professionist)
        {
            _context.Professionists.Add(professionist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessionist", new { id = professionist.ProfId }, professionist);
        }

        // DELETE: api/Professionists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Professionist>> DeleteProfessionist(int id)
        {
            var professionist = await _context.Professionists.FindAsync(id);
            if (professionist == null)
            {
                return NotFound();
            }

            _context.Professionists.Remove(professionist);
            await _context.SaveChangesAsync();

            return professionist;
        }

        private bool ProfessionistExists(int id)
        {
            return _context.Professionists.Any(e => e.ProfId == id);
        }
    }
}
