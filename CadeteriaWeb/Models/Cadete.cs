using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeteriaWeb.Models
{
    public class Cadete
    {
        private int ID;
        private string Nombre;
        private string Direccion;
        private int Telefono;

        public int id { get => ID; set => ID = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public int telefono { get => Telefono; set => Telefono = value; }
        
        //Constructores
        public Cadete ()
        {
            
        }
        public Cadete(int id, string nombre, string direccion, int telefono)
        {
            ID = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

    }
}