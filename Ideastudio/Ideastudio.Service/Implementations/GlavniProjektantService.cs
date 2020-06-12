using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.Service.Implementations
{
    public class GlavniProjektantService : IGlavniProjektantService
    {
        private readonly IGlavniProjektantRepository _glavniProjektantRepository;

        public GlavniProjektantService(IGlavniProjektantRepository glavniProjektantRepository)
        {
            _glavniProjektantRepository = glavniProjektantRepository;
        }

        public IEnumerable<GlavniProjektant> GetAll()
        {
            return _glavniProjektantRepository.GetAllGlavniProjekantiWithIdejnaResenja();
        }

        public GlavniProjektant Get(int id)
        {
            return _glavniProjektantRepository.GetAllGlavniProjekantiWithIdejnaResenja().FirstOrDefault(x => x.Id == id);
        }

        public ServiceResult<GlavniProjektant> Add(GlavniProjektant glavniProjektant)
        {
            _glavniProjektantRepository.Add(glavniProjektant);

            _glavniProjektantRepository.SaveChanges();

            return new ServiceResult<GlavniProjektant>(true, "Glavni projektant uspesno dodat.", glavniProjektant);
        }

        public ServiceResult<GlavniProjektant> Update(GlavniProjektant glavniProjektant)
        {
            _glavniProjektantRepository.Update(glavniProjektant);

            _glavniProjektantRepository.SaveChanges();

            return new ServiceResult<GlavniProjektant>(true, "Glavni projektant uspesno izmenjen.", glavniProjektant);
        }

        public ServiceResult<GlavniProjektant> Delete(GlavniProjektant glavniProjektant)
        {
            _glavniProjektantRepository.Delete(glavniProjektant);

            _glavniProjektantRepository.SaveChanges();

            return new ServiceResult<GlavniProjektant>(true, "Glavni projektant uspesno izbrisan.");
        }
    }
}
