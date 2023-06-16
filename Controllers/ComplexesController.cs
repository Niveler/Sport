using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sport.EFContext;
using Sport.Models;

namespace Sport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplexesController : ControllerBase
    {
        private readonly SportDbContext _context;

        public ComplexesController(SportDbContext context)
        {
            _context = context;
        }

        // GET: api/Complexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complex>>> GetComplexes()
        {
          if (_context.Complexes == null)
          {
              return NotFound();
          }
            return await _context.Complexes.ToListAsync();
        }

        // GET: api/Complexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Complex>> GetComplex(int id)
        {
          if (_context.Complexes == null)
          {
              return NotFound();
          }
            var complex = await _context.Complexes.FindAsync(id);

            if (complex == null)
            {
                return NotFound();
            }

            return complex;
        }

        // PUT: api/Complexes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplex(int id, Complex complex)
        {
            if (id != complex.Id)
            {
                return BadRequest();
            }

            _context.Entry(complex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplexExists(id))
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

        // POST: api/Complexes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Complex>> PostComplex(Complex complex)
        {
          if (_context.Complexes == null)
          {
              return Problem("Entity set 'SportDbContext.Complexes'  is null.");
          }
            _context.Complexes.Add(complex);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplex", new { id = complex.Id }, complex);
        }

        // DELETE: api/Complexes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplex(int id)
        {
            if (_context.Complexes == null)
            {
                return NotFound();
            }
            var complex = await _context.Complexes.FindAsync(id);
            if (complex == null)
            {
                return NotFound();
            }

            _context.Complexes.Remove(complex);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplexExists(int id)
        {
            return (_context.Complexes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
