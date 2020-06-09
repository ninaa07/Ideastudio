using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;

namespace Ideastudio.Service.Implementations
{
    public class ProstorijaService : IProstorijaService
    {
        private readonly IProstorijaRepository _prostorijaRepository;

        public ProstorijaService(IProstorijaRepository prostorijaRepository)
        {
            _prostorijaRepository = prostorijaRepository;
        }

        public IEnumerable<Prostorija> GetAll()
        {
            return _prostorijaRepository.GetAll();
        }

        public Prostorija Get(int id)
        {
            return _prostorijaRepository.Get(id);
        }

        public ServiceResult<Prostorija> Add(Prostorija prostorija)
        {
            _prostorijaRepository.Add(prostorija);

            _prostorijaRepository.SaveChanges();

            return new ServiceResult<Prostorija>(true, "Prostorija uspesno dodata.", prostorija);
        }

        public ServiceResult<Prostorija> Update(Prostorija prostorija)
        {
            _prostorijaRepository.Update(prostorija);

            _prostorijaRepository.SaveChanges();

            return new ServiceResult<Prostorija>(true, "Prostorija uspesno izmenjena.", prostorija);
        }

        public ServiceResult<Prostorija> Delete(Prostorija prostorija)
        {
            _prostorijaRepository.Delete(prostorija);

            _prostorijaRepository.SaveChanges();

            return new ServiceResult<Prostorija>(true, "Prostorija uspesno izbrisana.");
        }
    }
}
