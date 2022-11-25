using System.ComponentModel.DataAnnotations;

namespace CadeteriaWeb.ViewModels
{
    public class AltaCadeteViewModel
    {
        [Required][StringLength(100)][Display (Name = "Nombre del Cadete")]
        public string nombreCadete { get; set; }
       
        [Required][StringLength(120)][Display (Name = "Dirección")]
        public string Direccion { get; set; }

        [Required][Phone]
        public int Telefono { get; set; }

        public AltaCadeteViewModel () {}

        public AltaCadeteViewModel (string nombre, string dir, int tel)
        {
            this.nombreCadete = nombre;
            this.Direccion = dir;
            this.Telefono = tel;
        }
    }
}