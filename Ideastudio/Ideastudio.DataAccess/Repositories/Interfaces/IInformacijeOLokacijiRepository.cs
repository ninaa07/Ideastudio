using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IInformacijeOLokacijiRepository : IGenericRepository<InformacijeOLokaciji>
    {
        IEnumerable<InformacijeOLokaciji> GetAllInformacijeOLokacijiWithLokacijskeDozvole();
    }
}
