using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class InformacijeOLokacijiRepository : GenericRepository<InformacijeOLokaciji>, IInformacijeOLokacijiRepository
    {
        public InformacijeOLokacijiRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<InformacijeOLokaciji> GetAllInformacijeOLokacijiWithLokacijskeDozvole()
        {
            return _context.InformacijeOLokacijama.Include(x => x.LokacijskeDozvole);
        }
    }
}
