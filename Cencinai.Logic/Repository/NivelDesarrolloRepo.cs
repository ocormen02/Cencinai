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
            nivelDesarrollo.Id = 0;
            var entidadNivelDesarrollo = mapper.Map<NivelDesarrollo>(nivelDesarrollo);
            entidadNivelDesarrollo.Niño = null;
            entidadNivelDesarrollo.FechaCreacion = DateTime.Now;
            unitOfWork.NivelDesarrollo.Add(entidadNivelDesarrollo);
            
            unitOfWork.Complete();
        }
    }
}
