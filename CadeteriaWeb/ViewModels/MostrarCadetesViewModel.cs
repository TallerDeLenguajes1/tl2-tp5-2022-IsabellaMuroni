using System.ComponentModel.DataAnnotations;

namespace CadeteriaWeb.ViewModels
{
    public class MostrarCadetesViewModel
    {
        public int id { get; set; }
        public string nombreCadete { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public MostrarCadetesViewModel (){ }
        
        public MostrarCadetesViewModel(int _id, string nombre, string direccion, int tel)
        {
            this.id = _id;
            this.nombreCadete = nombre;
            this.Direccion = direccion;
            this.Telefono = tel;
        }
    }
}