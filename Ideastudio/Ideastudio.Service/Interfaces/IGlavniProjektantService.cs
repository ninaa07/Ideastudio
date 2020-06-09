using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IGlavniProjektantService
    {
        IEnumerable<GlavniProjektant> GetAll();

        GlavniProjektant Get(int id);

        ServiceResult<GlavniProjektant> Add(GlavniProjektant glavniProjektant);

        ServiceResult<GlavniProjektant> Update(GlavniProjektant glavniProjektant);

        ServiceResult<GlavniProjektant> Delete(GlavniProjektant glavniProjektant);
    }
}
