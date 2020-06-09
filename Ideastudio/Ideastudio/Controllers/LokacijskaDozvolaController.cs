using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ideastudio.Domain;
using Ideastudio.Models.LokacijskaDozvola.CreateLokacijskaDozvola;
using Ideastudio.Models.LokacijskaDozvola.EditLokacijskaDozvola;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ideastudio.Controllers
{
    [Route("api/lokacijskeDozvole")]
    [ApiController]
    public class LokacijskaDozvolaController : ControllerBase
    {
        private readonly ILokacijskaDozvolaService _lokacijskaDozvolaService;
        private readonly IMapper _mapper;

        public LokacijskaDozvolaController(ILokacijskaDozvolaService lokacijskaDozvolaService, IMapper mapper)
        {
            _lokacijskaDozvolaService = lokacijskaDozvolaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_lokacijskaDozvolaService.GetAll());
        }

        [HttpGet("{id}", Name = "GetLokacijskaDozvola")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<LokacijskaDozvola>(false, "'id' manji od 0."));

            var lokacijskaDozvola = _lokacijskaDozvolaService.Get(id);

            if (lokacijskaDozvola == null)
                return NotFound(new ServiceResult<LokacijskaDozvola>(false, "Lokacijska dozvola nije pronadjena."));

            return Ok(lokacijskaDozvola);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateLokacijskaDozvolaRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var lokacijskaDozvola = _mapper.Map<LokacijskaDozvola>(request);

            var rezultat = _lokacijskaDozvolaService.Add(lokacijskaDozvola);

            _mapper.Map<CreateLokacijskaDozvolaResponse>(rezultat.ResultObject);

            if (rezultat.Success)
                return Ok(rezultat);

            return BadRequest(rezultat);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditLokacijskaDozvolaRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id < 0)
                return BadRequest(new ServiceResult<LokacijskaDozvola>(false, "'id' manji od 0."));

            var lokacijskaDozvola = _lokacijskaDozvolaService.Get(id);

            if (lokacijskaDozvola == null)
                return NotFound(new ServiceResult<LokacijskaDozvola>(false, "Lokacijska dozvola nije pronadjena."));

            _mapper.Map(request, lokacijskaDozvola);

            var result = _lokacijskaDozvolaService.Update(lokacijskaDozvola);

            _mapper.Map<EditLokacijskaDozvolaResponse>(result.ResultObject);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<LokacijskaDozvola>(false, "'id' manji od 0."));

            var lokacijskaDozvola = _lokacijskaDozvolaService.Get(id);

            if (lokacijskaDozvola == null)
                return NotFound(new ServiceResult<LokacijskaDozvola>(false, "Lokacijska dozvola nije pronadjena."));

            var result = _lokacijskaDozvolaService.Delete(lokacijskaDozvola);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}