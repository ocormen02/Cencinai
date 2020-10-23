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

        public IIndiceMasaCorporalRepository IndiceMasaCorporal { get; private set; }

        public INiñoRepository Niño { get; private set; }

        public IPesoEdadRepository PesoEdad { get; private set; }

        public IPesoTallaRepository PesoTalla { get; private set; }

        public IProvinciaRepository Provincia { get; private set; }

        public IPuntuacionAreaDesarrolloRepository PuntuacionAreaDesarrollo { get; private set; }

        public IResponsableRepository Responsable { get; private set; }

        public ITallaEdadRepository TallaEdad { get; private set; }

        public UnitOfWork(CencinaiContext _context)
        {
            context = _context;

            Usuario = new UsuarioRepository(context);
            AreasDesarrollo = new AreasDesarrolloRepository(context);
            Canton = new CantonRepository(context);
            Categoria = new CategoriaRepository(context);
            Distrito = new DistritoRepository(context);
            IndiceMasaCorporal = new IndiceMasaCorporalRepository(context);
            Niño = new NiñoRepository(context);
            PesoEdad = new PesoEdadRepository(context);
            PesoTalla = new PesoTallaRepository(context);
            Provincia = new ProvinciaRepository(context);
            PuntuacionAreaDesarrollo = new PuntuacionAreaDesarrolloRepository(context);
            Responsable = new ResponsableRepository(context);
            TallaEdad = new TallaEdadRepository(context);
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
