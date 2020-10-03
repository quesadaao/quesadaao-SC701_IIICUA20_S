using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.Services
{
    public class RepositorioPais : IRepositorioPais
    {
        public List<string> ObtenerTodos()
        {
            return new List<string>() { "Rumania", "Rusia", "Eslovaquia", "Ucrania","Replublica Checa" }; 
        }
    }
}
