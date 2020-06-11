using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IGlavniProjektantRepository : IGenericRepository<GlavniProjektant>
    {
        IEnumerable<GlavniProjektant> GetAllGlavniProjekantiWithIdejnaResenja();
    }
}
