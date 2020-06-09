using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IVrstaPovrsineService
    {
        IEnumerable<VrstaPovrsine> GetAll();

        VrstaPovrsine Get(int id);

        ServiceResult<VrstaPovrsine> Add(VrstaPovrsine vrstaPovrsine);

        ServiceResult<VrstaPovrsine> Update(VrstaPovrsine vrstaPovrsine);

        ServiceResult<VrstaPovrsine> Delete(VrstaPovrsine vrstaPovrsine);
    }
}
