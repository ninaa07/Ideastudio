using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IProjekatZaGradjevinskuDozvoluRepository : IGenericRepository<ProjekatZaGradjevinskuDozvolu>
    {
        IEnumerable<ProjekatZaGradjevinskuDozvolu> GetAllPgdWithPovrsine();
    }
}
