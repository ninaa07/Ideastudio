using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IObjekatRepository : IGenericRepository<Objekat>
    {
        IEnumerable<Objekat> GetAllObjektiWithIdejnaResenja();
    }
}
