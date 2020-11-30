using AutoMapper;
using Cencinai.Data.Models;
using Cencinai.Data.UnitOfWork;
using Cencinai.Logic.Models;
using Cencinai.Logic.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository
{
    public class NiñoRepo : INiñoRepo
    {
        #region Constructor
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;

        public NiñoRepo(IUnitOfWork _unitOfWork,
            IMapper _mapper)
        {
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            unitOfWork = _unitOfWork;
        }
        #endregion Constructor

        public void AgregarNiño(NiñoModel niño)
        {
            var entidadNiño = mapper.Map<Niño>(niño);
            entidadNiño.Categoria = null;
            entidadNiño.Responsable = null;

            unitOfWork.Niño.Add(entidadNiño);
            unitOfWork.Complete();
        }

        public void BorrarNiño(NiñoModel niño)
        {
            var entidadNiño = unitOfWork.Niño.GetOne(x => x.Id == niño.Id).Result;
            unitOfWork.Niño.Remove(entidadNiño);

            unitOfWork.Complete();
        }

        public void EditarNiño(NiñoModel niño)
        {
            var entidadNiño = mapper.Map<Niño>(niño);
            entidadNiño.Responsable = null;
            entidadNiño.Categoria = null;

            unitOfWork.Niño.Update(entidadNiño);
            unitOfWork.Complete();
        }

        public async Task<NiñoModel> ObtenerNiñoPorId(int id)
        {
            var niño = await unitOfWork.Niño.GetOne(
                x => x.Id == id,
                CrearResponsableInclude(), CrearCategoriaInclude()
                );

            return mapper.Map<NiñoModel>(niño);
        }

        public int ObtenerEdadNiñoPorId(int id)
        {
            var fechaNacimiento = unitOfWork.Niño.GetOne(
                x => x.Id == id,
                CrearResponsableInclude(), CrearCategoriaInclude()
                ).Result.FechaNacimiento;

            var edad = DateTime.Now.Year - fechaNacimiento.Value.Year;

            return edad;
        }

        public async Task<PagedResult<NiñoModel>> ObtenerNiños(int pagina, string filtro)
        {
            PagedResult<NiñoModel> niños = new PagedResult<NiñoModel>();
            if (String.IsNullOrEmpty(filtro))
            {
                var resultado = await unitOfWork.Niño.GetAllPaged(pagina, 10, null, x => x.OrderBy(o => o.Nombre),
                    CrearResponsableInclude(), CrearCategoriaInclude());

                niños = mapper.Map<PagedResult<NiñoModel>>(resultado);
            }
            else
            {
                var resultado = await unitOfWork.Niño.GetAllPaged(pagina, 10, (s => s.Nombre.Contains(filtro) ||
                s.PrimerApellido.Contains(filtro) || s.SegundoApellido.Contains(filtro)),
                x => x.OrderBy(o => o.Nombre), CrearResponsableInclude(), CrearCategoriaInclude());

                niños = mapper.Map<PagedResult<NiñoModel>>(resultado);
            }

            return niños;
        }

        #region Includes
        public Func<IQueryable<Niño>, IIncludableQueryable<Niño, object>> CrearResponsableInclude()
        {
            return responsable => responsable.Include(x => x.Responsable);
        }
        public Func<IQueryable<Niño>, IIncludableQueryable<Niño, object>> CrearCategoriaInclude()
        {
            return categoria => categoria.Include(x => x.Categoria);
        }
        #endregion
    }
}
