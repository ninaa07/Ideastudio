using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class VrstaPovrsineRepository : GenericRepository<VrstaPovrsine>, IVrstaPovrsineRepository
    {
        public VrstaPovrsineRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
