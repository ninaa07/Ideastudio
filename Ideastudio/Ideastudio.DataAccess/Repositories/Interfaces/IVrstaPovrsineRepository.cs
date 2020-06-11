using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IVrstaPovrsineRepository : IGenericRepository<VrstaPovrsine>
    {
        IEnumerable<VrstaPovrsine> GetAllVrstePovrsineWithProstorijeAndPovrsine();
    }
}
