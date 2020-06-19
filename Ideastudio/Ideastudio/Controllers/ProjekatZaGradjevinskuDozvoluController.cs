using Ideastudio.Domain;
using Ideastudio.Service;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ideastudio.Controllers
{
    [Route("api/projektiZaGradjevinskuDozvolu")]
    [ApiController]
    public class ProjekatZaGradjevinskuDozvoluController : ControllerBase
    {
        private readonly IProjekatZaGradjevinskuDozvoluService _projekatZaGradjevinskuDozvoluService;

        public ProjekatZaGradjevinskuDozvoluController(IProjekatZaGradjevinskuDozvoluService projekatZaGradjevinskuDozvoluService)
        {
            _projekatZaGradjevinskuDozvoluService = projekatZaGradjevinskuDozvoluService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_projekatZaGradjevinskuDozvoluService.GetAll());
        }

        [HttpGet("{id}", Name = "GetProjekatZaGradjevinskuDozvolu")]
        public IActionResult Get(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "'id' manji od 0."));

            var projekatZaGradjevinskuDozvolu = _projekatZaGradjevinskuDozvoluService.Get(id);

            if (projekatZaGradjevinskuDozvolu == null)
                return NotFound(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "Projekat za gradjevinsku dozvolu nije pronadjen."));

            return Ok(projekatZaGradjevinskuDozvolu);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProjekatZaGradjevinskuDozvolu projekatZaGradjevinskuDozvolu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _projekatZaGradjevinskuDozvoluService.Add(projekatZaGradjevinskuDozvolu);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProjekatZaGradjevinskuDozvolu model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id < 0)
                return BadRequest(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "'id' manji od 0."));

            var projekatZaGradjevinskuDozvolu = _projekatZaGradjevinskuDozvoluService.Get(id);

            if (projekatZaGradjevinskuDozvolu == null)
                return NotFound(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "Projekat za gradjevinsku dozvolu nije pronadjen."));            

            foreach(var povrsina in model.Povrsine.Where(x => x.Status != Status.None))
            {
                if (povrsina.Status == Status.Insert)
                {
                    //povrsina.ProjekatZaGradjevinskuDozvoluId = projekatZaGradjevinskuDozvolu.Id;
                    //_projekatZaGradjevinskuDozvoluService.Dodaj
                }
            }

            var result = _projekatZaGradjevinskuDozvoluService.Update(projekatZaGradjevinskuDozvolu);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "'id' manji od 0."));

            var projekatZaGradjevinskuDozvolu = _projekatZaGradjevinskuDozvoluService.Get(id);

            if (projekatZaGradjevinskuDozvolu == null)
                return NotFound(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "Projekat za gradjevinsku dozvolu nije pronadjen."));

            var result = _projekatZaGradjevinskuDozvoluService.Delete(projekatZaGradjevinskuDozvolu);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}