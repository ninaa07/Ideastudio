using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class IdejnoResenjeRepository : GenericRepository<IdejnoResenje>, IIdejnoResenjeRepository
    {
        public IdejnoResenjeRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
