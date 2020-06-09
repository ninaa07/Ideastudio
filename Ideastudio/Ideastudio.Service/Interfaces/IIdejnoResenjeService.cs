using Ideastudio.Domain;
using System.Collections.Generic;

namespace Ideastudio.Service.Interfaces
{
    public interface IIdejnoResenjeService
    {
        public IEnumerable<IdejnoResenje> GetAll();

        public IdejnoResenje Get(int id);
        
        public ServiceResult<IdejnoResenje> Add(IdejnoResenje idejnoResenje);

        public ServiceResult<IdejnoResenje> Update(IdejnoResenje idejnoResenje);

        public ServiceResult<IdejnoResenje> Delete(IdejnoResenje idejnoResenje);
    }
}
