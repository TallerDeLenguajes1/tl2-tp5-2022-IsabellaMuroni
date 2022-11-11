using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeteriaWeb.Models;

namespace CadeteriaWeb.Models
{
    public class Cadete
    {
        private int ID;
        private string Nombre;
        private string Direccion;
        private int Telefono;
        private List<Pedido> ListaPedidos;

        public int id { get => ID; set => ID = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
        public int telefono { get => Telefono; set => Telefono = value; }
        public List<Pedido> listaPedidos { get => ListaPedidos; set => ListaPedidos; }

        //Constructores
        public Cadete ()
        {
            this.ListaPedidos = new List<Pedido>();            
        }

        public Cadete(int id, string nombre, string direccion, int telefono)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.ListaPedidos = new List<Pedido>();
        }

        //Metodos
        public void agregarPedido (Pedido pedido)
        {
            listaPedidos.Add(pedido);
        }
    }
}