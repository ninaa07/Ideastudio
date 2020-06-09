using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class PovrsinaRepository : GenericRepository<Povrsina>, IPovrsinaRepository
    {
        public PovrsinaRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
