using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ideastudio.Service.Implementations
{
    public class ProjekatZaGradjevinskuDozvoluService : IProjekatZaGradjevinskuDozvoluService
    {
        private readonly IProjekatZaGradjevinskuDozvoluRepository _projekatZaGradjevinskuDozvoluRepository;

        public ProjekatZaGradjevinskuDozvoluService(IProjekatZaGradjevinskuDozvoluRepository projekatZaGradjevinskuDozvoluRepository)
        {
            _projekatZaGradjevinskuDozvoluRepository = projekatZaGradjevinskuDozvoluRepository;
        }

        public IEnumerable<ProjekatZaGradjevinskuDozvolu> GetAll()
        {
            return _projekatZaGradjevinskuDozvoluRepository.GetAllPgdWithPovrsine();
        }

        public ProjekatZaGradjevinskuDozvolu Get(int id)
        {
            return _projekatZaGradjevinskuDozvoluRepository.GetAllPgdWithPovrsine().FirstOrDefault(x => x.Id == id);
        }

        public ServiceResult<ProjekatZaGradjevinskuDozvolu> Add(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu)
        {
            _projekatZaGradjevinskuDozvoluRepository.Add(projekatZaGradjevinskuDozvolu);

            _projekatZaGradjevinskuDozvoluRepository.SaveChanges();

            return new ServiceResult<ProjekatZaGradjevinskuDozvolu>(true, "Projekat za gradjevinsku dozvolu uspesno dodat.", projekatZaGradjevinskuDozvolu);
        }

        public ServiceResult<ProjekatZaGradjevinskuDozvolu> Update(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu)
        {
            _projekatZaGradjevinskuDozvoluRepository.Update(projekatZaGradjevinskuDozvolu);

            _projekatZaGradjevinskuDozvoluRepository.SaveChanges();

            return new ServiceResult<ProjekatZaGradjevinskuDozvolu>(true, "Projekat za gradjevinsku dozvolu uspesno izmenjen.", projekatZaGradjevinskuDozvolu);
        }

        public ServiceResult<ProjekatZaGradjevinskuDozvolu> Delete(ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu)
        {
            _projekatZaGradjevinskuDozvoluRepository.Delete(projekatZaGradjevinskuDozvolu);

            _projekatZaGradjevinskuDozvoluRepository.SaveChanges();

            return new ServiceResult<ProjekatZaGradjevinskuDozvolu>(true, "Projekat za gradjevinsku dozvolu uspesno izbrisan.", projekatZaGradjevinskuDozvolu);
        }
    }
}
