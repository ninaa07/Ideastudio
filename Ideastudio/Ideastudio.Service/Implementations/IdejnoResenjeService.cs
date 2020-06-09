using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;

namespace Ideastudio.Service.Implementations
{
    public class IdejnoResenjeService : IIdejnoResenjeService
    {
        private readonly IIdejnoResenjeRepository _idejnoResenjeRepository;

        public IdejnoResenjeService(IIdejnoResenjeRepository idejnoResenjeRepository)
        {
            _idejnoResenjeRepository = idejnoResenjeRepository;
        }

        public IEnumerable<IdejnoResenje> GetAll()
        {
            return _idejnoResenjeRepository.GetAll();
        }

        public IdejnoResenje Get(int id)
        {
            return _idejnoResenjeRepository.Get(id);
        }

        public ServiceResult<IdejnoResenje> Add(IdejnoResenje idejnoResenje)
        {
            _idejnoResenjeRepository.Add(idejnoResenje);

            _idejnoResenjeRepository.SaveChanges();

            return new ServiceResult<IdejnoResenje>(true, "Idejno resenje uspesno dodato.", idejnoResenje);
        }

        public ServiceResult<IdejnoResenje> Update(IdejnoResenje idejnoResenje)
        {
            _idejnoResenjeRepository.Update(idejnoResenje);

            _idejnoResenjeRepository.SaveChanges();

            return new ServiceResult<IdejnoResenje>(true, "Idejno resenje uspesno izmenjeno.", idejnoResenje);
        }

        public ServiceResult<IdejnoResenje> Delete(IdejnoResenje idejnoResenje)
        {
            _idejnoResenjeRepository.Delete(idejnoResenje);

            _idejnoResenjeRepository.SaveChanges();

            return new ServiceResult<IdejnoResenje>(true, "Idejno resenje uspesno izbrisano.");
        }
    }
}
