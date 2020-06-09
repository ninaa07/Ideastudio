using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class ProstorijaRepository : GenericRepository<Prostorija>, IProstorijaRepository
    {
        public ProstorijaRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
