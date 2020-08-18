using Cencinai.Data.Models;
using Cencinai.Data.Repository.Generic;
using Cencinai.Data.Repository.Interface;


namespace Cencinai.Data.Repository
{
    public class IndiceMasaCorporalRepository : Repository<IndiceMasaCorporal>, IIndiceMasaCorporalRepository
    {
        public IndiceMasaCorporalRepository(CencinaiContext context)
          : base(context)
        {
        }

        public CencinaiContext CencinaiContext
        {
            get { return dbContext as CencinaiContext; }
        }
    }
}
