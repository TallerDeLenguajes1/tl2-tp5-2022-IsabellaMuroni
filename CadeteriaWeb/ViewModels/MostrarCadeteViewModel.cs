using System.ComponentModel.DataAnnotations;

namespace CadeteriaWeb.ViewModels
{
    public class MostrarCadeteViewModel
    {
        public int id { get; set; }
        public string nombreCadete { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
    }
}