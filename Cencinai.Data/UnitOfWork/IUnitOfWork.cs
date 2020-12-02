using Cencinai.Data.Repository.Interface;
using System;

namespace Cencinai.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IUsuariorRepository Usuario { get; }

        INivelDesarrolloRepository NivelDesarrollo { get; }

        ICantonRepository Canton { get; }

        ICategoriaRepository Categoria { get; }

        IDistritoRepository Distrito { get; }

        INiñoRepository Niño { get; }

        IEstadoNutricionalRepository EstadoNutricional { get; }

        IProvinciaRepository Provincia { get; }

        IResponsableRepository Responsable { get; }


        int Complete();
    }
}
