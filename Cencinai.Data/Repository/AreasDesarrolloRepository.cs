using Cencinai.Data.Models;
using Cencinai.Data.Repository.Generic;
using Cencinai.Data.Repository.Interface;


namespace Cencinai.Data.Repository
{
    public class AreasDesarrolloRepository: Repository<AreasDesarrollo>, IAreasDesarrolloRepository
    {
        public AreasDesarrolloRepository(CencinaiContext context)
          : base(context)
        {
        }

        public CencinaiContext CencinaiContext
        {
            get { return dbContext as CencinaiContext; }
        }
    }
}
