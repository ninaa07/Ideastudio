using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IPovrsinaService
    {
        IEnumerable<Povrsina> GetAll();

        Povrsina Get(int id);

        ServiceResult<Povrsina> Add(Povrsina povrsina);

        ServiceResult<Povrsina> Update(Povrsina povrsina);

        ServiceResult<Povrsina> Delete(Povrsina povrsina);
    }
}
