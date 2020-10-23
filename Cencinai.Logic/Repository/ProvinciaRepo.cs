using AutoMapper;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository
{
    public class ProvinciaRepo : IProvinciaRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public ProvinciaRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public async Task<IEnumerable<ProvinciaModel>> ObtenerProvincias()
        {
            var resultado = await unitOfWork.Provincia.GetAll(
                null, x => x.OrderBy(o => o.Nombre));

            return mapper.Map<IEnumerable<ProvinciaModel>>(resultado);
        }
    }
}
