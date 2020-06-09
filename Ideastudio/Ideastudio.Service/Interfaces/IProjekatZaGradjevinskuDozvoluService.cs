using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IProjekatZaGradjevinskuDozvoluService
    {
        IEnumerable<ProjekatZaGradjevinskuDozvolu> GetAll();

        ProjekatZaGradjevinskuDozvolu Get(int id);

        ServiceResult<ProjekatZaGradjevinskuDozvolu> Add(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu);

        ServiceResult<ProjekatZaGradjevinskuDozvolu> Update(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu);

        ServiceResult<ProjekatZaGradjevinskuDozvolu> Delete(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu);
    }
}
