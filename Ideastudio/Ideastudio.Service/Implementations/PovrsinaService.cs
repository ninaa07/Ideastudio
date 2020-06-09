using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Ideastudio.Service.Interfaces;
using System.Collections.Generic;

namespace Ideastudio.Service.Implementations
{
    public class PovrsinaService : IPovrsinaService
    {
        private readonly IPovrsinaRepository _povrsinaRepository;

        public PovrsinaService(IPovrsinaRepository povrsinaRepository)
        {
            _povrsinaRepository = povrsinaRepository;
        }

        public IEnumerable<Povrsina> GetAll()
        {
            return _povrsinaRepository.GetAll();
        }

        public Povrsina Get(int id)
        {
            return _povrsinaRepository.Get(id);
        }

        public ServiceResult<Povrsina> Add(Povrsina povrsina)
        {
            _povrsinaRepository.Add(povrsina);

            _povrsinaRepository.SaveChanges();

            return new ServiceResult<Povrsina>(true, "Povrsina uspesno dodata.", povrsina);
        }

        public ServiceResult<Povrsina> Update(Povrsina povrsina)
        {
            _povrsinaRepository.Update(povrsina);

            _povrsinaRepository.SaveChanges();

            return new ServiceResult<Povrsina>(true, "Povrsina uspesno izmenjena.", povrsina);
        }

        public ServiceResult<Povrsina> Delete(Povrsina povrsina)
        {
            _povrsinaRepository.Delete(povrsina);

            _povrsinaRepository.SaveChanges();

            return new ServiceResult<Povrsina>(true, "Povrsina uspesno izbrisana.");
        }
    }
}
