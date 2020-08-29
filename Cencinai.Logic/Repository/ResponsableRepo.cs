using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using System;
using System.Collections.Generic;
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
            try
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
            catch (Exception ex)
            { }
            
        }

        public void BorrarResponsable(ResponsableModel responsable)
        {
            throw new NotImplementedException();
        }

        public void EditarResponsable(ResponsableModel responsable)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsableModel> ObtenerResponsablePorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ResponsableModel>> ObtenerResponsables(int pagina, string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
