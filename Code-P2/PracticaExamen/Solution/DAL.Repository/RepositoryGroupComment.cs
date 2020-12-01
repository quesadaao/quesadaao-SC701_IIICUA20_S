using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    // Clase que es una extension de repository
    // Implementa la interfase IRepositoryGroupComment 
    // Esta interfase se encarga de implementar metodos que necesiten implementar el include para devolver la informacion
    public class RepositoryGroupComment : Repository<GroupComment>, IRepositoryGroupComment
    {
        //Constructor correspondiente a la clase
        //Parametro Context para poderlo recibir y utilizar 
        public RepositoryGroupComment(SolutionDBContext context)
            : base(context)
        { }

        //Metodo encargado de traer datos con releaciones
        //Como podemos ver hacemos el include encargado de hacer la respectiva asociacion
        public async Task<IEnumerable<GroupComment>> GetAllWithGroupCommentsAsync()
        {
            return await SolutionDBContext.GroupComments
                .Include(m => m.GroupUpdate)
                .ToListAsync();
        }

        //Metodo encargado de traer datos con releaciones
        //Como podemos ver hacemos el include encargado de hacer la respectiva asociacion
        public async Task<GroupComment> GetWithGroupCommentByIdAsync(int id)
        {
            return await SolutionDBContext.GroupComments
                .Include(m => m.GroupUpdate)
                .SingleOrDefaultAsync(m => m.GroupUpdateId == id);
        }

        //Metodo para inicializar el contexto y poderlo utilizar en los metodos 
        private SolutionDBContext SolutionDBContext
        {
            get { return dBContext as SolutionDBContext; }
        }
    }
}
