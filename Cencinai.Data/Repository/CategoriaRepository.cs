using Cencinai.Data.Models;
using Cencinai.Data.Repository.Generic;
using Cencinai.Data.Repository.Interface;


namespace Cencinai.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(CencinaiContext context)
          : base(context)
        {
        }

        public CencinaiContext CencinaiContext
        {
            get { return dbContext as CencinaiContext; }
        }
    }
}
