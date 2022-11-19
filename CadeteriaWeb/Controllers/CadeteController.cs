using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadeteriaWeb.Models;
using CadeteriaWeb.ViewModels;
using System.Data.SQLite;

namespace CadeteriaWeb.Controllers
{
    //[Route("Cadete")]
    public class CadeteController : Controller
    {
        public List<Cadete> listaCadetes = new List<Cadete>();
        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet][Route("Cadete")]
        public IActionResult Cadete ()
        {
            
            return View();
        }

        
        [HttpGet]
        public IActionResult AltaCadete ()
        {
            return View ();
        }        

        public IActionResult EditarCadete ()
        {
            return View();
        }

        //Probando Base de Datos
        public IActionResult MostrarCadete ()
        {
            var cadenaDeConexion = @"Data Source = DB\PedidosDB.db; Version = 3;";
            var connection = new SQLiteConnection(cadenaDeConexion);

            connection.Open();

            var queryString = "select * from Cadete;";
            var comando = new SQLiteCommand(queryString, connection);
            List<string> cadetes = new List<string>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nombre = reader["cadete nombre"].ToString();
                    cadetes.Add(nombre);
                }
            }

             connection.Close();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}