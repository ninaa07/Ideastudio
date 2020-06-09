using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IProstorijaService
    {
        IEnumerable<Prostorija> GetAll();

        Prostorija Get(int id);

        ServiceResult<Prostorija> Add(Prostorija prostorija);

        ServiceResult<Prostorija> Update(Prostorija prostorija);

        ServiceResult<Prostorija> Delete(Prostorija prostorija);
    }
}
