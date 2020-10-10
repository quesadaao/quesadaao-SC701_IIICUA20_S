using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;

namespace Solution.UI.Controllers
{
    public class PaisController : Controller
    {
        public IRepositorioPais repo { get; }

        public PaisController(IRepositorioPais repositorio) 
        {
            repo = repositorio;
        }

        public IActionResult Index()
        {
            //throw new ApplicationException("Ha ocurrido algo malo");
            //List<string> Pais = new List<string>() { "Rumania", "Rusia", "Eslovaquia","Ucrania" };
            return View(repo.ObtenerTodos());
        }
    }
}
