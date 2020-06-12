using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.Service.Implementations
{
    public class InformacijeOLokacijiService : IInformacijeOLokacijiService
    {
        private readonly IInformacijeOLokacijiRepository _informacijeOLokacijiRepository;

        public InformacijeOLokacijiService (IInformacijeOLokacijiRepository informacijeOLokacijiRepository)
        {
            _informacijeOLokacijiRepository = informacijeOLokacijiRepository;
        }

        public IEnumerable<InformacijeOLokaciji> GetAll()
        {
            return _informacijeOLokacijiRepository.GetAllInformacijeOLokacijiWithLokacijskeDozvole();
        }

        public InformacijeOLokaciji Get(int id)
        {
            return _informacijeOLokacijiRepository.GetAllInformacijeOLokacijiWithLokacijskeDozvole().FirstOrDefault(x => x.Id == id);
        }

        public ServiceResult<InformacijeOLokaciji> Add(InformacijeOLokaciji informacijeOLokaciji)
        {
            _informacijeOLokacijiRepository.Add(informacijeOLokaciji);

            _informacijeOLokacijiRepository.SaveChanges();

            return new ServiceResult<InformacijeOLokaciji>(true, "Informacije o lokaciji uspesno dodate.", informacijeOLokaciji);
        }

        public ServiceResult<InformacijeOLokaciji> Update(InformacijeOLokaciji informacijeOLokaciji)
        {
            _informacijeOLokacijiRepository.Update(informacijeOLokaciji);

            _informacijeOLokacijiRepository.SaveChanges();

            return new ServiceResult<InformacijeOLokaciji>(true, "Informacije o lokaciji uspesno izmenjene.", informacijeOLokaciji);
        }

        public ServiceResult<InformacijeOLokaciji> Delete(InformacijeOLokaciji informacijeOLokaciji)
        {
            _informacijeOLokacijiRepository.Delete(informacijeOLokaciji);

            _informacijeOLokacijiRepository.SaveChanges();

            return new ServiceResult<InformacijeOLokaciji>(true, "Informacije o lokaciji uspesno izbrisane.");
        }
    }
}
