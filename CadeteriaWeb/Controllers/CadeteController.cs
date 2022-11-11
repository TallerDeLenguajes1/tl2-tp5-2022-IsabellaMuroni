using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadeteriaWeb.Models;
using CadeteriaWeb.ViewModels;

namespace CadeteriaWeb.Controllers
{
    [Route("Cadete")]
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Cadete ()
        {
            
            return View();
        }

        /*
        [HttpGet]
        public IActionResult AltaCadete ()
        {
            return View (new AltaCadeteViewModel() { nombreCadete = "Juan", Direccion = "Av. Independencia 1800", Telefono = 555});
        }*/
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}