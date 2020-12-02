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
    public class EstadoNutricionalRepo : IEstadoNutricionalRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public EstadoNutricionalRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public void AgregarEstadoNutricional(EstadoNutricionalModel estadoNutricional)
        {
            var entidadEstadoNutricional = mapper.Map<EstadoNutricional>(estadoNutricional);
            entidadEstadoNutricional.Niño = null;
            entidadEstadoNutricional.FechaCreacion = DateTime.Now;
            unitOfWork.EstadoNutricional.Add(entidadEstadoNutricional);
            
            unitOfWork.Complete();
        }
    }
}
