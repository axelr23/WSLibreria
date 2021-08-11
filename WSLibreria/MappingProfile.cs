using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WSLibreria.Models;
using WSLibreria.DTO;

namespace WSLibreria
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Autores, AutoresDTO>().ReverseMap();
                
                //.ForMember(d => d.Id, o => o.MapFrom(s => s.Id));

            CreateMap<Libros, LibrosDTO>().ForMember(d => d.Existencia, o => o.MapFrom(s => s.CantidadInventario > 1))
                .ReverseMap();
        }
    }
}
