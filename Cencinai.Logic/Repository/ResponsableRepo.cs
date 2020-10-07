using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository
{
    public class ResponsableRepo : IResponsableRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public ResponsableRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public void AgregarResponsable(ResponsableModel responsable)
        {
            var entidadResponsable = mapper.Map<Responsable>(responsable);
            entidadResponsable.FechaCreacion = DateTime.Now;
            entidadResponsable.FechaActualizacion = DateTime.Now;
            entidadResponsable.Direccion.FechaCreacion = DateTime.Now;
            entidadResponsable.Direccion.FechaActualizacion = DateTime.Now;
            unitOfWork.Direccion.Add(entidadResponsable.Direccion);
            unitOfWork.Complete();
            entidadResponsable.DireccionId = entidadResponsable.Direccion.Id;
            unitOfWork.Responsable.Add(entidadResponsable);

            unitOfWork.Complete();
        }

        public void BorrarResponsable(ResponsableModel responsable)
        {
            var entidadResponsable = mapper.Map<Responsable>(responsable);
            unitOfWork.Responsable.Remove(entidadResponsable);

            unitOfWork.Complete();
        }

        public void EditarResponsable(ResponsableModel responsable)
        {
            var responsableBD = ObtenerResponsablePorId(responsable.Id).Result;

            responsable.FechaCreacion = responsableBD.FechaCreacion;
            responsable.FechaActualizacion = DateTime.Now;

            var entidadResponsable = mapper.Map<Responsable>(responsable);
            unitOfWork.Responsable.Update(entidadResponsable);

            unitOfWork.Complete();
        }

        public async Task<ResponsableModel> ObtenerResponsablePorId(int id)
        {
            var responsable = await unitOfWork.Responsable.GetOne(
                x => x.Id == id, 
                CrearDireccionInclude(), CrearProvinciaInclude(), 
                CrearCantonInclude(), CrearDistritoInclude());

            return mapper.Map<ResponsableModel>(responsable);
        }

        public async Task<PagedResult<ResponsableModel>> ObtenerResponsables(int pagina, string filtro)
        {
            PagedResult<ResponsableModel> responsables = new PagedResult<ResponsableModel>();
            if (String.IsNullOrEmpty(filtro))
            {
                var resultado = await unitOfWork.Responsable.GetAllPaged(pagina, 10, null, x => x.OrderBy(o => o.Nombre),
                    CrearDireccionInclude(), CrearProvinciaInclude(), CrearCantonInclude(), CrearDistritoInclude());

                responsables = mapper.Map<PagedResult<ResponsableModel>>(resultado);
            }
            else
            {
                var resultado = await unitOfWork.Responsable.GetAllPaged(pagina, 10, (s => s.Nombre.Contains(filtro) ||
                s.PrimerApellido.Contains(filtro) || s.SegundoApellido.Contains(filtro)));

                responsables = mapper.Map<PagedResult<ResponsableModel>>(resultado);
            }

            return responsables;
        }

        #region Includes
        public Func<IQueryable<Responsable>, IIncludableQueryable<Responsable, object>> CrearDireccionInclude()
        {
            return direccion => direccion.Include(x => x.Direccion);
        }

        public Func<IQueryable<Responsable>, IIncludableQueryable<Responsable, object>> CrearProvinciaInclude()
        {
            return provincia => provincia.Include(x => x.Direccion.Provincia);
        }

        public Func<IQueryable<Responsable>, IIncludableQueryable<Responsable, object>> CrearCantonInclude()
        {
            return canton => canton.Include(x => x.Direccion.Canton);
        }

        public Func<IQueryable<Responsable>, IIncludableQueryable<Responsable, object>> CrearDistritoInclude()
        {
            return distrito => distrito.Include(x => x.Direccion.Distrito);
        }
        #endregion
    }
}
