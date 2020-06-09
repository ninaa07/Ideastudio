using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IObjekatService
    {
        IEnumerable<Objekat> GetAll();

        Objekat Get(int id);

        ServiceResult<Objekat> Add(Objekat objekat);

        ServiceResult<Objekat> Update(Objekat objekat);

        ServiceResult<Objekat> Delete(Objekat objekat);
    }
}
