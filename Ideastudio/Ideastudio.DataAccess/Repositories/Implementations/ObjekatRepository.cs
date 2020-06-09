using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class ObjekatRepository : GenericRepository<Objekat>, IObjekatRepository
    {
        public ObjekatRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
