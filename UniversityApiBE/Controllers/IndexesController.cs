using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.DataAcces;
using UniversityApiBE.Models.DataModels;

namespace UniversityApiBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexesController : ControllerBase
    {
        private readonly UniversityDBContext _context;

        public IndexesController(UniversityDBContext context)
        {
            _context = context;
        }

        // GET: api/Indiexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UniversityApiBE.Models.DataModels.Index>>> GetIndexes()
        {
          if (_context.Indexes == null)
          {
              return NotFound();
          }
            return await _context.Indexes.ToListAsync();
        }

        // GET: api/Indiexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UniversityApiBE.Models.DataModels.Index>> GetIndex(int id)
        {
          if (_context.Indexes == null)
          {
              return NotFound();
          }
            var index = await _context.Indexes.FindAsync(id);

            if (index == null)
            {
                return NotFound();
            }

            return index;
        }

        // PUT: api/Indiexes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndex(int id, UniversityApiBE.Models.DataModels.Index index)
        {
            if (id != index.Id)
            {
                return BadRequest();
            }

            _context.Entry(index).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndexExists(id))
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

        // POST: api/Indiexes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UniversityApiBE.Models.DataModels.Index>> PostIndex(UniversityApiBE.Models.DataModels.Index index)
        {
          if (_context.Indexes == null)
          {
              return Problem("Entity set 'UniversityDBContext.Indexes'  is null.");
          }
            _context.Indexes.Add(index);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIndex", new { id = index.Id }, index);
        }

        // DELETE: api/Indiexes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndex(int id)
        {
            if (_context.Indexes == null)
            {
                return NotFound();
            }
            var index = await _context.Indexes.FindAsync(id);
            if (index == null)
            {
                return NotFound();
            }

            _context.Indexes.Remove(index);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IndexExists(int id)
        {
            return (_context.Indexes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
