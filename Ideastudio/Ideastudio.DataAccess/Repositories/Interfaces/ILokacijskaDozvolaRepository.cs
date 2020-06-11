using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface ILokacijskaDozvolaRepository : IGenericRepository<LokacijskaDozvola>
    {
        IEnumerable<LokacijskaDozvola> GetAllLokacijskeDozvoleWithIdejnaResenja();
    }
}
