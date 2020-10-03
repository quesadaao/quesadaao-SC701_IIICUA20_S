using Solution.UI.Data;
using Solution.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.Services
{
    public class PaisEFRepositorio   : IRepositoryEFPais
    {
        public ApplicationDbContext DbContext;
        public PaisEFRepositorio(ApplicationDbContext context) {
            DbContext = context;        
        }
        public List<Pais> ObtenerTodos()
        {
            return DbContext.pais.ToList();
        }
    }
}
