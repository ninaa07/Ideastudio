using AutoMapper;
using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/idejnaResenja")]
    [ApiController]
    public class IdejnoResenjeController : ControllerBase
    {
        private readonly IIdejnoResenjeService _idejnoResenjeService;

        public IdejnoResenjeController(IIdejnoResenjeService idejnoResenjeService)
        {
            _idejnoResenjeService = idejnoResenjeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_idejnoResenjeService.GetAll());
        }

        [HttpGet("{id}", Name = "GetIdejnoResenje")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<IdejnoResenje>(false, "'id' manji od 0."));

            var idejnoResenje = _idejnoResenjeService.Get(id);

            if (idejnoResenje == null)
                return NotFound(new ServiceResult<IdejnoResenje>(false, "Idejno resenje nije pronadjeno."));

            return Ok(idejnoResenje);
        }

        [HttpPost]
        public IActionResult Post([FromBody] IdejnoResenje idejnoResenje)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _idejnoResenjeService.Add(idejnoResenje);

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
                return BadRequest(new ServiceResult<IdejnoResenje>(false, "'id' manji od 0."));

            var idejnoResenje = _idejnoResenjeService.Get(id);

            if (idejnoResenje == null)
                return NotFound(new ServiceResult<IdejnoResenje>(false, "Idejno resenje nije pronadjeno."));

            var rezultat = _idejnoResenjeService.Update(idejnoResenje);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<IdejnoResenje>(false, "'id' manji od 0."));

            var idejnoResenje = _idejnoResenjeService.Get(id);

            if (idejnoResenje == null)
                return NotFound(new ServiceResult<IdejnoResenje>(false, "Idejno resenje nije pronadjeno."));

            var rezultat = _idejnoResenjeService.Delete(idejnoResenje);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }
    }
}