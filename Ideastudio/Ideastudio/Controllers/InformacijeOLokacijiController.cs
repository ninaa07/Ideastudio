using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/informacijeOLokaciji")]
    [ApiController]
    public class InformacijeOLokacijiController : ControllerBase
    {
        private readonly IInformacijeOLokacijiService _informacijeOLokacijiService;

        public InformacijeOLokacijiController(IInformacijeOLokacijiService informacijeOLokacijiService)
        {
            _informacijeOLokacijiService = informacijeOLokacijiService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_informacijeOLokacijiService.GetAll());
        }

        [HttpGet("{id}", Name = "GetInformacijeOLokaciji")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<InformacijeOLokaciji>(false, "'id' manji od 0."));

            var informacijeOLokaciji = _informacijeOLokacijiService.Get(id);

            if (informacijeOLokaciji == null)
                return NotFound(new ServiceResult<InformacijeOLokaciji>(false, "Informacije o lokaciji nisu pronadjene."));

            return Ok(informacijeOLokaciji);
        }

        [HttpPost]
        public IActionResult Post([FromBody] InformacijeOLokaciji informacijeOLokaciji)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _informacijeOLokacijiService.Add(informacijeOLokaciji);

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
                return BadRequest(new ServiceResult<InformacijeOLokaciji>(false, "'id' manji od 0."));

            var informacijeOLokaciji = _informacijeOLokacijiService.Get(id);

            if (informacijeOLokaciji == null)
                return NotFound(new ServiceResult<InformacijeOLokaciji>(false, "Informacije o lokaciji nisu pronadjene."));

            var result = _informacijeOLokacijiService.Update(informacijeOLokaciji);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<InformacijeOLokaciji>(false, "'id' manji od 0."));

            var informacijeOLokaciji = _informacijeOLokacijiService.Get(id);

            if (informacijeOLokaciji == null)
                return NotFound(new ServiceResult<InformacijeOLokaciji>(false, "Informacije o lokaciji nisu pronadjene."));

            var result = _informacijeOLokacijiService.Delete(informacijeOLokaciji);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}