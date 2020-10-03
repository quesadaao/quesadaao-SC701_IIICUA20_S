using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;

namespace Solution.UI.Controllers
{
    public class PaisEFController : Controller
    {
        public IRepositoryEFPais repo { get; set; }

        public PaisEFController(IRepositoryEFPais repository) {
            repo = repository;        
        }

        public IActionResult Index()
        {
            return View(repo.ObtenerTodos());
        }
    }
}
