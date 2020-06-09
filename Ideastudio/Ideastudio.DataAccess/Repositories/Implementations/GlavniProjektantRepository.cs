using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class GlavniProjektantRepository : GenericRepository<GlavniProjektant>, IGlavniProjektantRepository
    {
        public GlavniProjektantRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
