using System.ComponentModel.DataAnnotations;

namespace CadeteriaWeb.ViewModels
{
    public class MostrarCadetesViewModel
    {
        public int id { get; set; }
         [Required]
        public string nombre { get; set; }
         [Required]
        public string direccion { get; set; }
         [Required][Phone]
        public int telefono { get; set; }

        public MostrarCadetesViewModel (){ }
        
        /* public MostrarCadetesViewModel(int _id, string nombre, string direccion, int tel)
        {
            this.id = _id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = tel;
        } */
    }
}