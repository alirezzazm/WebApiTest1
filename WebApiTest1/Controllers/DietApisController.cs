using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest1.Data;
using WebApiTest1.Models;

namespace WebApiTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietApisController : ControllerBase
    {
        private readonly WebApiTest1Context _context;

        public DietApisController(WebApiTest1Context context)
        {
            _context = context;
        }

        // GET: api/DietApis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DietApi>>> GetDietApi()
        {
            return await _context.DietApi.ToListAsync();
        }

        // GET: api/DietApis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DietApi>> GetDietApi(int id)
        {
            var dietApi = await _context.DietApi.FindAsync(id);

            if (dietApi == null)
            {
                return NotFound();
            }

            return dietApi;
        }

        // PUT: api/DietApis/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDietApi(int id, DietApi dietApi)
        {
            if (id != dietApi.Id)
            {
                return BadRequest();
            }

            _context.Entry(dietApi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DietApiExists(id))
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

        // POST: api/DietApis
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DietApi>> PostDietApi(DietApi dietApi)
        {
            _context.DietApi.Add(dietApi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDietApi", new { id = dietApi.Id }, dietApi);
        }

        // DELETE: api/DietApis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DietApi>> DeleteDietApi(int id)
        {
            var dietApi = await _context.DietApi.FindAsync(id);
            if (dietApi == null)
            {
                return NotFound();
            }

            _context.DietApi.Remove(dietApi);
            await _context.SaveChangesAsync();

            return dietApi;
        }

        private bool DietApiExists(int id)
        {
            return _context.DietApi.Any(e => e.Id == id);
        }
    }
}
