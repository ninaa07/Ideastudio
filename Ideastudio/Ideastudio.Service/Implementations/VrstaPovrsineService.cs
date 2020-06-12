using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.Service.Implementations
{
    public class VrstaPovrsineService : IVrstaPovrsineService
    {
        private readonly IVrstaPovrsineRepository _vrstaPovrsineRepository;

        public VrstaPovrsineService(IVrstaPovrsineRepository vrstaPovrsineRepository)
        {
            _vrstaPovrsineRepository = vrstaPovrsineRepository;
        }

        public IEnumerable<VrstaPovrsine> GetAll()
        {
            return _vrstaPovrsineRepository.GetAllVrstePovrsineWithProstorijeAndPovrsine();
        }

        public VrstaPovrsine Get(int id)
        {
            return _vrstaPovrsineRepository.GetAllVrstePovrsineWithProstorijeAndPovrsine().FirstOrDefault(x => x.Id == id);
        }

        public ServiceResult<VrstaPovrsine> Add(VrstaPovrsine vrstaPovrsine)
        {
            _vrstaPovrsineRepository.Add(vrstaPovrsine);

            _vrstaPovrsineRepository.SaveChanges();

            return new ServiceResult<VrstaPovrsine>(true, "Vrsta povrsine uspesno dodata.", vrstaPovrsine);
        }

        public ServiceResult<VrstaPovrsine> Update(VrstaPovrsine vrstaPovrsine)
        {
            _vrstaPovrsineRepository.Update(vrstaPovrsine);

            _vrstaPovrsineRepository.SaveChanges();

            return new ServiceResult<VrstaPovrsine>(true, "Vrsta povrsine uspesno izmenjena.", vrstaPovrsine);
        }

        public ServiceResult<VrstaPovrsine> Delete(VrstaPovrsine vrstaPovrsine)
        {
            _vrstaPovrsineRepository.Delete(vrstaPovrsine);

            _vrstaPovrsineRepository.SaveChanges();

            return new ServiceResult<VrstaPovrsine>(true, "Vrsta povrsine uspesno izbrisana.");
        }
    }
}
