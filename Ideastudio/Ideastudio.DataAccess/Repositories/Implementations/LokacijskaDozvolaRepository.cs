using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class LokacijskaDozvolaRepository : GenericRepository<LokacijskaDozvola>, ILokacijskaDozvolaRepository
    {
        public LokacijskaDozvolaRepository(ApplicationContext context) : base(context)
        {
            
        }

        public IEnumerable<LokacijskaDozvola> GetAllLokacijskeDozvoleWithIdejnaResenja()
        {
            return _context.LokacijskeDozvole.Include(x => x.IdejnaResenja);
        }
    }
}
