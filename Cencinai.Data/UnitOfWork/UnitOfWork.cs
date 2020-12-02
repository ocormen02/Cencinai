using Cencinai.Data.Repository;
using Cencinai.Data.Repository.Interface;


namespace Cencinai.Data.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly CencinaiContext context;

        public IUsuariorRepository Usuario { get; private set; }

        public IAreasDesarrolloRepository AreasDesarrollo { get; private set; }

        public ICantonRepository Canton { get; private set; }

        public ICategoriaRepository Categoria { get; private set; }

        public IDistritoRepository Distrito { get; private set; }

        public INiñoRepository Niño { get; private set; }

        public IEstadoNutricionalRepository EstadoNutricional { get; private set; }

        public IProvinciaRepository Provincia { get; private set; }

        public IResponsableRepository Responsable { get; private set; }

        public UnitOfWork(CencinaiContext _context)
        {
            context = _context;

            Usuario = new UsuarioRepository(context);
            AreasDesarrollo = new AreasDesarrolloRepository(context);
            Canton = new CantonRepository(context);
            Categoria = new CategoriaRepository(context);
            Distrito = new DistritoRepository(context);
            Niño = new NiñoRepository(context);
            EstadoNutricional = new EstadoNutricionalRepository(context);
            Provincia = new ProvinciaRepository(context);
            Responsable = new ResponsableRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
