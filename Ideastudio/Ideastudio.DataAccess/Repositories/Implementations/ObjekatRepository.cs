using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class ObjekatRepository : GenericRepository<Objekat>, IObjekatRepository
    {
        public ObjekatRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<Objekat> GetAllObjektiWithIdejnaResenja()
        {
            return _context.Objekti.Include(x => x.IdejnaResenja);
        }
    }
}
