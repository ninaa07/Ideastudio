using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/objekti")]
    [ApiController]
    public class ObjekatController : ControllerBase
    {
        private readonly IObjekatService _objekatService;

        public ObjekatController(IObjekatService objekatService)
        {
            _objekatService = objekatService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_objekatService.GetAll());
        }

        [HttpGet("{id}", Name = "GetObjekat")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Objekat>(false, "'id' manji od 0."));

            var objekat = _objekatService.Get(id);

            if (objekat == null)
                return NotFound(new ServiceResult<Objekat>(false, "Objekat nije pronadjen."));

            return Ok(objekat);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Objekat objekat)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _objekatService.Add(objekat);

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
                return BadRequest(new ServiceResult<Objekat>(false, "'id' manji od 0."));

            var objekat = _objekatService.Get(id);

            if (objekat == null)
                return NotFound(new ServiceResult<Objekat>(false, "Objekat nije pronadjen."));

            var result = _objekatService.Update(objekat);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Objekat>(false, "'id' manji od 0."));

            var objekat = _objekatService.Get(id);

            if (objekat == null)
                return NotFound(new ServiceResult<Objekat>(false, "Objekat nije pronadjen."));

            var result = _objekatService.Delete(objekat);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}