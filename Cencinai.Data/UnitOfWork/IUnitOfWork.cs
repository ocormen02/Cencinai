using Cencinai.Data.Repository.Interface;
using System;

namespace Cencinai.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IUsuariorRepository Usuario { get; }

        IAreasDesarrolloRepository AreasDesarrollo { get; }

        ICantonRepository Canton { get; }

        ICategoriaRepository Categoria { get; }

        IDireccionRepository Direccion { get; }

        IDistritoRepository Distrito { get; }

        IIndiceMasaCorporalRepository IndiceMasaCorporal { get; }

        INiñoRepository Niño { get; }

        IPesoEdadRepository PesoEdad { get; }

        IPesoTallaRepository PesoTalla { get; }

        IProvinciaRepository Provincia { get; }

        IPuntuacionAreaDesarrolloRepository PuntuacionAreaDesarrollo { get; }

        IResponsableRepository Responsable { get; }

        IResponsableNiñoRepository ResponsableNiño { get; }

        ITallaEdadRepository TallaEdad { get; }

        int Complete();
    }
}
