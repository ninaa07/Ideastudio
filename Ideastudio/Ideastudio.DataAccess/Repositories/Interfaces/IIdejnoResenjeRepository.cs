using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IIdejnoResenjeRepository : IGenericRepository<IdejnoResenje>
    {
        IEnumerable<IdejnoResenje> GetAllIdejnaResenjaWithPgd();
    }
}
