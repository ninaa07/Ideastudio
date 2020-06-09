using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;

namespace Ideastudio.Service.Implementations
{
    public class ObjekatService : IObjekatService
    {
        private readonly IObjekatRepository _objekatRepository;

        public ObjekatService(IObjekatRepository objekatRepository)
        {
            _objekatRepository = objekatRepository;
        }

        public IEnumerable<Objekat> GetAll()
        {
            return _objekatRepository.GetAll();
        }

        public Objekat Get(int id)
        {
            return _objekatRepository.Get(id);
        }

        public ServiceResult<Objekat> Add(Objekat objekat)
        {
            _objekatRepository.Add(objekat);

            _objekatRepository.SaveChanges();

            return new ServiceResult<Objekat>(true, "Objekat uspesno dodat.", objekat);
        }

        public ServiceResult<Objekat> Update(Objekat objekat)
        {
            _objekatRepository.Update(objekat);

            _objekatRepository.SaveChanges();

            return new ServiceResult<Objekat>(true, "Objekat uspesno izmenjen.", objekat);
        }

        public ServiceResult<Objekat> Delete(Objekat objekat)
        {
            _objekatRepository.Delete(objekat);

            _objekatRepository.SaveChanges();

            return new ServiceResult<Objekat>(true, "Objekat uspesno izbrisan.");
        }
    }
}
