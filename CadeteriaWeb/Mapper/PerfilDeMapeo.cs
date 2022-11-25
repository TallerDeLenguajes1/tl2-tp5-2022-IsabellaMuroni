using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeteriaWeb.Models;
using CadeteriaWeb.ViewModels;
using AutoMapper;

namespace CadeteriaWeb.Mapper
{
    public class PerfilDeMapeo : Profile
    {
        public PerfilDeMapeo ()
        {
            //Cadetes: Alta, Baja, Modificación
            CreateMap<Cadete, AltaCadeteViewModel>().ReverseMap();
            CreateMap<Cadete, MostrarCadetesViewModel>().ReverseMap();
        }
        
    }
}