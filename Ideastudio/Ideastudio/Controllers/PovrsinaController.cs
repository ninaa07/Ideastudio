using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/povrsine")]
    [ApiController]
    public class PovrsinaController : ControllerBase
    {
        private readonly IPovrsinaService _povrsinaService;

        public PovrsinaController(IPovrsinaService povrsinaService)
        {
            _povrsinaService = povrsinaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_povrsinaService.GetAll());
        }

        [HttpGet("{id}", Name = "GetPovrsina")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Povrsina>(false, "'id' manji od 0."));

            var povrsina = _povrsinaService.Get(id);

            if (povrsina == null)
                return NotFound(new ServiceResult<Povrsina>(false, "Povrsina nije pronadjena."));

            return Ok(povrsina);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Povrsina povrsina)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _povrsinaService.Add(povrsina);

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
                return BadRequest(new ServiceResult<Povrsina>(false, "'id' manji od 0."));

            var povrsina = _povrsinaService.Get(id);

            if (povrsina == null)
                return NotFound(new ServiceResult<Povrsina>(false, "Povrsina nije pronadjena."));

            var rezultat = _povrsinaService.Update(povrsina);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<Povrsina>(false, "'id' manji od 0."));

            var povrsina = _povrsinaService.Get(id);

            if (povrsina == null)
                return NotFound(new ServiceResult<Povrsina>(false, "Povrsina nije pronadjena."));

            var rezultat = _povrsinaService.Delete(povrsina);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }
    }
}