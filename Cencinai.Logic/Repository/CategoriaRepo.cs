using AutoMapper;
using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository
{
    public class CategoriaRepo : ICategoriaRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public CategoriaRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public async Task<IEnumerable<CategoriaModel>> ListarCategorias()
        {
            var resultado = await unitOfWork.Categoria.GetAll(
                null, 
                x => x.OrderBy(o => o.Nombre));

            return mapper.Map<IEnumerable<CategoriaModel>>(resultado);
        }
    }
}
