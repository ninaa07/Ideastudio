using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class GlavniProjektantRepository : GenericRepository<GlavniProjektant>, IGlavniProjektantRepository
    {
        public GlavniProjektantRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<GlavniProjektant> GetAllGlavniProjekantiWithIdejnaResenja()
        {
            return _context.GlavniProjektanti.Include(x => x.IdejnaResenja);
        }
    }
}
