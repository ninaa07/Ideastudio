using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class ProjekatZaGradjevinskuDozvoluRepository : GenericRepository<ProjekatZaGradjevinskuDozvolu>, IProjekatZaGradjevinskuDozvoluRepository
    {
        public ProjekatZaGradjevinskuDozvoluRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<ProjekatZaGradjevinskuDozvolu> GetAllPgdWithPovrsine()
        {
            return _context.ProjektiZaGradjevinskuDozvolu.Include(x => x.Povrsine);
        }
    }
}
