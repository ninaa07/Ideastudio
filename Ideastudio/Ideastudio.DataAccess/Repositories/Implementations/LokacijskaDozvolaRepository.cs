using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class LokacijskaDozvolaRepository : GenericRepository<LokacijskaDozvola>, ILokacijskaDozvolaRepository
    {
        public LokacijskaDozvolaRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
