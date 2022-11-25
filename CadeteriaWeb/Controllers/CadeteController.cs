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
using AutoMapper;
using CadeteriaWeb.Repositories;


namespace CadeteriaWeb.Controllers
{
    //[Route("Cadete")]
    public class CadeteController : Controller
    {
        public List<Cadete> listaCadetes = new List<Cadete>();
        private readonly ILogger<CadeteController> _logger;
        private readonly IMapper _mapper;
        private readonly ICadeteRepository _repoCadete;

        public CadeteController(ILogger<CadeteController> logger, IMapper mapper, ICadeteRepository repoCadete)
        {
            _logger = logger;
            _mapper = mapper;
            _repoCadete = repoCadete;
        }
        
        [HttpGet][Route("Cadete")]//Pág. inicio Cadetes: muestra la lista de cadetes
        public IActionResult Cadete ()
        {
            var cadetes = _repoCadete.GetCadetes();
            var mostrarCadetes = _mapper.Map<List<MostrarCadetesViewModel>>(cadetes);

            return View(mostrarCadetes);
        }

    
        public IActionResult AltaCadete ()
        {
            return View ();
        }        
        
        [HttpPost]
        public IActionResult AltaCadete (AltaCadeteViewModel nuevoCadeteVM)
        {
            var nuevoCadete = _mapper.Map<Cadete>(nuevoCadeteVM);
            _repoCadete.Insert(nuevoCadete);
            
            return RedirectToAction("Cadete"); 
        }

        public IActionResult EditarCadete (int id)
        {
            var cadete = _repoCadete.GetCadete(id);
            EditarCadeteViewModel editarCade = _mapper.Map<EditarCadeteViewModel>(cadete);
            
            return View("EditarCadete");
        }

        [HttpPost]
        public IActionResult EditarCadete (EditarCadeteViewModel cadeteVM)
        {
            var cadete = _mapper.Map<Cadete>(cadeteVM);
            _repoCadete.Update(cadete);
            
            return RedirectToAction("Cadete");
        }

        //Probando Base de Datos

        /*[HttpGet]
        public List<Cadete> GetCadetes ()
        {
            List<Cadete> cadetes = new List<Cadete>();
            //List<MostrarCadetesViewModel> cadetes = new List<MostrarCadetesViewModel>();

            var cadenaDeConexion = @"Data Source = DB\Pedidos_DB.db; Version = 3;";
            var connection = new SQLiteConnection(cadenaDeConexion);

            connection.Open();

            var queryString = "select * from Cadete;";//Consulta
            var comando = new SQLiteCommand(queryString, connection);
            //List<string> cadetes = new List<string>();

            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    //var nombre = reader["cadete nombre"].ToString();
                    //cadetes.Add(nombre);
                    var _id = Convert.ToInt32(reader[0]);
                    var nombre = reader[1].ToString();
                    var telefono = Convert.ToInt32(reader[2]);
                    var direccion = reader[3].ToString();
                    cadetes.Add(new Cadete (_id, nombre,  direccion, telefono));
                    //cadetes.Add(new MostrarCadetesViewModel());
                }
            }

             connection.Close();

            return cadetes;
        }*/
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}