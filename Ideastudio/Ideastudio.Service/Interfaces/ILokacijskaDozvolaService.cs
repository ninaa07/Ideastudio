using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface ILokacijskaDozvolaService
    {
        IEnumerable<LokacijskaDozvola> GetAll();

        LokacijskaDozvola Get(int id);

        ServiceResult<LokacijskaDozvola> Add(LokacijskaDozvola lokacijskaDozvola);

        ServiceResult<LokacijskaDozvola> Update(LokacijskaDozvola lokacijskaDozvola);

        ServiceResult<LokacijskaDozvola> Delete(LokacijskaDozvola lokacijskaDozvola);
    }
}
