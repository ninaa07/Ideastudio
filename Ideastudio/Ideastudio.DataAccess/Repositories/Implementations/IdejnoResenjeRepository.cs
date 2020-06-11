using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class IdejnoResenjeRepository : GenericRepository<IdejnoResenje>, IIdejnoResenjeRepository
    {
        public IdejnoResenjeRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<IdejnoResenje> GetAllIdejnaResenjaWithPgd()
        {
            return _context.IdejnaResenja.Include(x => x.ProjektiZaGradjevinskuDozvolu);
        }
    }
}
