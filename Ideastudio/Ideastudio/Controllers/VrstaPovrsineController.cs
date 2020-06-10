using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/vrstePovrsina")]
    [ApiController]
    public class VrstaPovrsineController : ControllerBase
    {
        private readonly IVrstaPovrsineService _vrstaPovrsineService;

        public VrstaPovrsineController(IVrstaPovrsineService vrstaPovrsineService)
        {
            _vrstaPovrsineService = vrstaPovrsineService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_vrstaPovrsineService.GetAll());
        }

        [HttpGet("{id}", Name = "GetVrstaPovrsine")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<VrstaPovrsine>(false, "'id' manji od 0."));

            var vrstaPovrsine = _vrstaPovrsineService.Get(id);

            if (vrstaPovrsine == null)
                return NotFound(new ServiceResult<VrstaPovrsine>(false, "Vrsta povrsine nije pronadjena."));

            return Ok(vrstaPovrsine);
        }

        [HttpPost]
        public IActionResult Post([FromBody] VrstaPovrsine vrstaPovrsine)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _vrstaPovrsineService.Add(vrstaPovrsine);

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
                return BadRequest(new ServiceResult<VrstaPovrsine>(false, "'id' manji od 0."));

            var vrstaPovrsine = _vrstaPovrsineService.Get(id);

            if (vrstaPovrsine == null)
                return NotFound(new ServiceResult<VrstaPovrsine>(false, "Vrsta povrsine nije pronadjena."));

            var result = _vrstaPovrsineService.Update(vrstaPovrsine);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<VrstaPovrsine>(false, "'id' manji od 0."));

            var vrstaPovrsine = _vrstaPovrsineService.Get(id);

            if (vrstaPovrsine == null)
                return NotFound(new ServiceResult<VrstaPovrsine>(false, "Vrsta povrsine nije pronadjena."));

            var result = _vrstaPovrsineService.Delete(vrstaPovrsine);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}