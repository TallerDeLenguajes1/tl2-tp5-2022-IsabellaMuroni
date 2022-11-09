using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeteriaWeb.Models
{
    public class Cadeteria
    {
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListaCadetes;

        public string nombre { get => Nombre; set => Nombre = value; }
        public string telefono { get => Telefono; set => Telefono = value; }
        public List<Cadete> listaCadetes { get => ListaCadetes; set => ListaCadetes = value; }

        public Cadeteria(string nombre, string telefono, List<Cadete> listaCadetes)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            listaCadetes = new List<Cadete>();
        }
    }
}