using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class InformacijeOLokacijiRepository : GenericRepository<InformacijeOLokaciji>, IInformacijeOLokacijiRepository
    {
        public InformacijeOLokacijiRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
