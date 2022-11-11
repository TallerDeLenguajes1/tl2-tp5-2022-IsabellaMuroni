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
    }
}