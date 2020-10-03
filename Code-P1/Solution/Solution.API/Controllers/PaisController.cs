using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data = Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly SolutionDBContext _context;

        public PaisController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Pais>>> GetPais()
        {
            return new Solution.BS.Pais(_context).GetAll().ToList();
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Pais>> GetPais(int id)
        {
            var pais = new Solution.BS.Pais(_context).GetOneById(id);

            if (pais == null)
            {
                return NotFound();
            }

            return pais;
        }

        // PUT: api/Pais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, data.Pais pais)
        {
            if (id != pais.Id)
            {
                return BadRequest();
            }
            
            try
            {
                new Solution.BS.Pais(_context).Update(pais);
            }
            catch (Exception)
            {
                if (!PaiExists(id))
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

        // POST: api/Pais
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Pais>> PostPais(data.Pais pais)
        {
            new Solution.BS.Pais(_context).Insert(pais);

            return CreatedAtAction("GetPais", new { id = pais.Id }, pais);
        }

        // DELETE: api/Pais/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Pais>> DeletePais(int id)
        {
            var pais = new Solution.BS.Pais(_context).GetOneById(id);
            if (pais == null)
            {
                return NotFound();
            }

            new Solution.BS.Pais(_context).Delete(pais);

            return pais;
        }

        private bool PaiExists(int id)
        {
            return (new Solution.BS.Pais(_context).GetOneById(id)!=null);
        }
    }
}
