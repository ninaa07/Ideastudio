using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class ProjekatZaGradjevinskuDozvoluRepository : GenericRepository<ProjekatZaGradjevinskuDozvolu>, IProjekatZaGradjevinskuDozvoluRepository
    {
        public ProjekatZaGradjevinskuDozvoluRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
