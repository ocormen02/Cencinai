using AutoMapper;
using Cencinai.Data.Models;
using Cencinai.Logic.Models;
using System.Collections.Generic;

namespace Cencinai.Logic
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AreasDesarrollo, AreasDesarrolloModel>().ReverseMap();
            CreateMap<Canton, CantonModel>().ReverseMap();
            CreateMap<Provincia, ProvinciaModel>().ReverseMap();
            CreateMap<Distrito, DistritoModel>().ReverseMap();
            CreateMap<Categoria, CategoriaModel>().ReverseMap();
            CreateMap<Niño, NiñoModel>().ReverseMap();
            CreateMap<PagedResult<Niño>, PagedResult<NiñoModel>>().ReverseMap();
            CreateMap<Responsable, ResponsableModel>().ReverseMap();
            CreateMap<EstadoNutricional, EstadoNutricionalModel>().ReverseMap();
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
            CreateMap<PagedResult<Usuario>, PagedResult<UsuarioModel>>().ReverseMap();
            CreateMap<PagedResult<Responsable>, PagedResult<ResponsableModel>>().ReverseMap();
        }
    }
}
