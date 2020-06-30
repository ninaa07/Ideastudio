using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.Service.Implementations
{
    public class LokacijskaDozvolaService : ILokacijskaDozvolaService
    {
        private readonly ILokacijskaDozvolaRepository _lokacijskaDozvolaRepository;

        public LokacijskaDozvolaService(ILokacijskaDozvolaRepository lokacijskaDozvolaRepository)
        {
            _lokacijskaDozvolaRepository = lokacijskaDozvolaRepository;
        }

        public IEnumerable<LokacijskaDozvola> GetAll()
        {
            return _lokacijskaDozvolaRepository.GetAllLokacijskeDozvoleWithIdejnaResenja();
        }

        public LokacijskaDozvola Get(int id)
        {
            return _lokacijskaDozvolaRepository.GetAllLokacijskeDozvoleWithIdejnaResenja().FirstOrDefault(x => x.Id == id);
        }

        public ServiceResult<LokacijskaDozvola> Add(LokacijskaDozvola lokacijskaDozvola)
        {
            lokacijskaDozvola.DatumIzdavanja = System.DateTime.Now;

            _lokacijskaDozvolaRepository.Add(lokacijskaDozvola);

            _lokacijskaDozvolaRepository.SaveChanges();

            return new ServiceResult<LokacijskaDozvola>(true, "Lokacijska dozvola uspesno dodata.", lokacijskaDozvola);
        }

        public ServiceResult<LokacijskaDozvola> Update(LokacijskaDozvola lokacijskaDozvola)
        {
            lokacijskaDozvola.DatumIzdavanja = System.DateTime.Now;

            _lokacijskaDozvolaRepository.Update(lokacijskaDozvola);

            _lokacijskaDozvolaRepository.SaveChanges();

            return new ServiceResult<LokacijskaDozvola>(true, "Lokacijska dozvola uspesno izmenjena.", lokacijskaDozvola);
        }

        public ServiceResult<LokacijskaDozvola> Delete(LokacijskaDozvola lokacijskaDozvola)
        {
            _lokacijskaDozvolaRepository.Delete(lokacijskaDozvola);

            _lokacijskaDozvolaRepository.SaveChanges();

            return new ServiceResult<LokacijskaDozvola>(true, "Lokacijska dozvola uspesno izbrisana.", lokacijskaDozvola);
        }
    }
}
