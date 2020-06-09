using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/prostorije")]
    [ApiController]
    public class ProstorijaController : ControllerBase
    {
        private readonly IProstorijaService _prostorijaService;

        public ProstorijaController(IProstorijaService prostorijaService)
        {
            _prostorijaService = prostorijaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_prostorijaService.GetAll());
        }

        [HttpGet("{id}", Name = "GetProstorija")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Prostorija>(false, "'id' manji od 0."));

            var prostorija = _prostorijaService.Get(id);

            if (prostorija == null)
                return NotFound(new ServiceResult<Prostorija>(false, "Prostorija nije pronadjena."));

            return Ok(prostorija);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Prostorija prostorija)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _prostorijaService.Add(prostorija);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id < 0)
                return BadRequest(new ServiceResult<Prostorija>(false, "'id' manji od 0."));

            var prostorija = _prostorijaService.Get(id);

            if (prostorija == null)
                return NotFound(new ServiceResult<Prostorija>(false, "Prostorija nije pronadjena."));

            var rezultat = _prostorijaService.Update(prostorija);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Prostorija>(false, "'id' manji od 0."));

            var prostorija = _prostorijaService.Get(id);

            if (prostorija == null)
                return NotFound(new ServiceResult<Prostorija>(false, "Prostorija nije pronadjena."));

            var rezultat = _prostorijaService.Delete(prostorija);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }
    }
}