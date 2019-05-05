using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISP.Controller
{
    public class HomeController : ControllerBase
    {
        private ICarga _carga;
        public HomeController(ICarga carga)
        {
            _carga = carga;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var resposta = _carga.Get(); 
            return Ok(resposta);
        }
    }
}
