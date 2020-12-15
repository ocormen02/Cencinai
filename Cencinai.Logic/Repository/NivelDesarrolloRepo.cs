using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cencinai.Logic.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Cencinai.Logic.Repository
{
    public class NivelDesarrolloRepo : INivelDesarrolloRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public NivelDesarrolloRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public void AgregarNivelDesarrollo(NivelDesarrolloModel nivelDesarrollo)
        {
            var niveles = unitOfWork.NivelDesarrollo.GetAll(null, null, null).Result.Where(x => x.NiñoId == nivelDesarrollo.NiñoId).ToList();

            if (niveles.Count > 0)
            {
                foreach (var item in niveles)
                {
                    unitOfWork.NivelDesarrollo.Remove(item);
                }
                unitOfWork.Complete();
            }

            nivelDesarrollo.Id = 0;
            var entidadNivelDesarrollo = mapper.Map<NivelDesarrollo>(nivelDesarrollo);
            entidadNivelDesarrollo.Niño = null;
            entidadNivelDesarrollo.FechaCreacion = DateTime.Now;
            unitOfWork.NivelDesarrollo.Add(entidadNivelDesarrollo);
            
            unitOfWork.Complete();
        }

        public async Task<IList<NivelDesarrolloModel>> ObtenerReporteNivelDesarrollo()
        {
            var listaEstadoNutricional = await unitOfWork.NivelDesarrollo.GetAll(
                null, null,
                CrearNiñoInclude(), CrearResponsableInclude());

            return mapper.Map<IList<NivelDesarrolloModel>>(listaEstadoNutricional);
        }


        #region Includes
        public Func<IQueryable<NivelDesarrollo>, IIncludableQueryable<NivelDesarrollo, object>> CrearNiñoInclude()
        {
            return niño => niño.Include(x => x.Niño);
        }
        public Func<IQueryable<NivelDesarrollo>, IIncludableQueryable<NivelDesarrollo, object>> CrearResponsableInclude()
        {
            return responsable => responsable.Include(x => x.Niño.Responsable);
        }
        #endregion
    }
}
