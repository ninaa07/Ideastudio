using AutoMapper;
using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/glavniProjektanti")]
    [ApiController]
    public class GlavniProjektantController : ControllerBase
    {
        private readonly IGlavniProjektantService _glavniProjektantService;

        public GlavniProjektantController(IGlavniProjektantService glavniProjektantService)
        {
            _glavniProjektantService = glavniProjektantService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_glavniProjektantService.GetAll());
        }

        [HttpGet("{id}", Name = "GetGlavniProjektant")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<GlavniProjektant>(false, "'id' manji od 0."));

            var glavniProjektant = _glavniProjektantService.Get(id);

            if (glavniProjektant == null)
                return NotFound(new ServiceResult<GlavniProjektant>(false, "Glavni projektant nije pronadjen."));

            return Ok(glavniProjektant);
        }

        [HttpPost]
        public IActionResult Post([FromBody] GlavniProjektant glavniProjektant)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var rezultat = _glavniProjektantService.Add(glavniProjektant);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id < 0)
                return BadRequest(new ServiceResult<GlavniProjektant>(false, "'id' manji od 0."));

            var glavniProjektant = _glavniProjektantService.Get(id);

            if (glavniProjektant == null)
                return NotFound(new ServiceResult<GlavniProjektant>(false, "Glavni projektant nije pronadjen."));

            var result = _glavniProjektantService.Update(glavniProjektant);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<GlavniProjektant>(false, "'id' manji od 0."));

            var glavniProjektant = _glavniProjektantService.Get(id);

            if (glavniProjektant == null)
                return NotFound(new ServiceResult<GlavniProjektant>(false, "Glavni projektant nije pronadjen."));

            var rezultat = _glavniProjektantService.Delete(glavniProjektant);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }
    }
}