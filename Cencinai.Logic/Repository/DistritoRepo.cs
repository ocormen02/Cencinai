using AutoMapper;
using Cencinai.Data.Models;
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
    public class DistritoRepo : IDistritoRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public DistritoRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public async Task<IEnumerable<DistritoModel>> ObtenerDistritos(int cantonId)
        {
            var resultado = await unitOfWork.Distrito.GetAll(
                c => c.CantonId == cantonId, 
                x => x.OrderBy(o => o.Nombre));

            return mapper.Map<IEnumerable<DistritoModel>>(resultado);
        }
    }
}
