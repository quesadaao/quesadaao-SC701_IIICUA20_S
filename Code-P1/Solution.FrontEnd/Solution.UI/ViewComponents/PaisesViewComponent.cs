using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public IRepositoryEFPais repository { get; set; }

        public PaisesViewComponent(IRepositoryEFPais repo) 
        {
            repository = repo;        
        }

        public IViewComponentResult Invoke() 
        {
            return View(repository.ObtenerTodos());
        }
    }
}
