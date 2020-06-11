using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class VrstaPovrsineRepository : GenericRepository<VrstaPovrsine>, IVrstaPovrsineRepository
    {
        public VrstaPovrsineRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<VrstaPovrsine> GetAllVrstePovrsineWithProstorijeAndPovrsine()
        {
            return _context.VrstePovrsine.Include(x => x.Prostorije).Include(x => x.Povrsine);
        }
    }
}
