using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using data = DO.Objects;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupCommentController : ControllerBase
    {
        private readonly SolutionDBContext _context;
        // Declaracion del automapper para poder castear los objetos 
        private readonly IMapper _mapper;

        // Necesitamos agregar Automapper en el constructor 
        // La arquitectura de .Net Core nos indica recibirlo para trabajar con Dependency Inyection
        public GroupCommentController(SolutionDBContext context, IMapper mapper)
        {
            this._mapper = mapper;
            _context = context;
        }

        // GET: api/GroupComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.GroupComment>>> GetGroupComments()
        {
            // Declaramos la variable para traer los datos correspondientes 
            var aux = await new BS.GroupComment(_context).GetAllInclude();

            // Hacemos el casting del dato una vez que ya el proceso finaliza en la base de datos 
            var mapaux = _mapper.Map<IEnumerable<data.GroupComment>, IEnumerable<DataModels.GroupComment>>(aux).ToList();
            return mapaux;
        }

        // GET: api/GroupComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.GroupComment>> GetGroupComment(int id)
        {
            var groupComment = new BS.GroupComment(_context).GetOneById(id);
            var mapaux = _mapper.Map<data.GroupComment, DataModels.GroupComment>(groupComment);            
            if (mapaux == null)
            {
                return NotFound();
            }
            return mapaux;
        }

        // PUT: api/GroupComments/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupComment(int id, DataModels.GroupComment groupComment)
        {
            if (id != groupComment.GroupCommentId)
            {
                return BadRequest();
            }
            var mapaux = _mapper.Map<DataModels.GroupComment, data.GroupComment>(groupComment);
            try
            {
                new BS.GroupComment(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!GroupCommentExists(id))
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

        // POST: api/GroupComments
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DataModels.GroupComment>> PostGroupComment(DataModels.GroupComment groupComment)
        {
            var mapaux = _mapper.Map<DataModels.GroupComment, data.GroupComment>(groupComment);
            new BS.GroupComment(_context).Insert(mapaux);

            return CreatedAtAction("GetGroupComment", new { id = groupComment.GroupCommentId }, groupComment);
        }

        // DELETE: api/GroupComments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.GroupComment>> DeleteGroupComment(int id)
        {
            var groupComment = new BS.GroupComment(_context).GetOneById(id);
            if (groupComment == null)
            {
                return NotFound();
            }
            new BS.GroupComment(_context).Delete(groupComment);
            var mapaux = _mapper.Map<data.GroupComment, DataModels.GroupComment>(groupComment);
            return mapaux;
        }

        private bool GroupCommentExists(int id)
        {
            return (new BS.GroupComment(_context).GetOneById(id) != null);
        }
    }
}