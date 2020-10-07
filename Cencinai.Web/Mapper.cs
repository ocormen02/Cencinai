using AutoMapper;
using Cencinai.Data.Models;
using Cencinai.Logic.Models;

namespace Cencinai.Logic
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AreasDesarrollo, AreasDesarrolloModel>().ReverseMap();
            CreateMap<Base, BaseModel>().ReverseMap();
            CreateMap<Canton, CantonModel>().ReverseMap();
            CreateMap<Provincia, ProvinciaModel>().ReverseMap();
            CreateMap<Distrito, DistritoModel>().ReverseMap();
            CreateMap<Categoria, CategoriaModel>().ReverseMap();
            CreateMap<Direccion, DireccionModel>().ReverseMap();
            CreateMap<IndiceMasaCorporal, IndiceMasaCorporalModel>().ReverseMap();
            CreateMap<Niño, NiñoModel>().ReverseMap();
            CreateMap<PesoEdad, PesoEdadModel>().ReverseMap();
            CreateMap<PesoTalla, PesoTallaModel>().ReverseMap();
            CreateMap<PuntuacionAreaDesarrollo, PuntuacionAreaDesarrolloModel>().ReverseMap();
            CreateMap<Responsable, ResponsableModel>().ReverseMap();
            CreateMap<TallaEdad, TallaEdadModel>().ReverseMap();
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
            CreateMap<PagedResult<Usuario>, PagedResult<UsuarioModel>>().ReverseMap();
            CreateMap<PagedResult<Responsable>, PagedResult<ResponsableModel>>().ReverseMap();
        }
    }
}
