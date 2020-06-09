using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IInformacijeOLokacijiService
    {
        IEnumerable<InformacijeOLokaciji> GetAll();

        InformacijeOLokaciji Get(int id);

        ServiceResult<InformacijeOLokaciji> Add(InformacijeOLokaciji informacijeOLokaciji);

        ServiceResult<InformacijeOLokaciji> Update(InformacijeOLokaciji informacijeOLokaciji);

        ServiceResult<InformacijeOLokaciji> Delete(InformacijeOLokaciji informacijeOLokaciji);
    }
}
