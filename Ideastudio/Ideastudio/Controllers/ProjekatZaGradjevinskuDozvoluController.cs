using AutoMapper;
using Ideastudio.Domain;
using Ideastudio.Models.ProjekatZaGradjevinskuDozvolu.CreateProjekatZaGradjevinskuDozvolu;
using Ideastudio.Models.ProjekatZaGradjevinskuDozvolu.EditProjekatZaGradjevinskuDozvolu;
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
        private readonly IMapper _mapper;
        private readonly IPovrsinaService _povrsinaService;

        public ProjekatZaGradjevinskuDozvoluController(IProjekatZaGradjevinskuDozvoluService projekatZaGradjevinskuDozvoluService, IMapper mapper, IPovrsinaService povrsinaService)
        {
            _projekatZaGradjevinskuDozvoluService = projekatZaGradjevinskuDozvoluService;
            _mapper = mapper;
            _povrsinaService = povrsinaService;
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
        public IActionResult Post([FromBody] CreateProjekatZaGradjevinskuDozvoluRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var projekatZaGradjevinskuDozvolu = _mapper.Map<ProjekatZaGradjevinskuDozvolu>(request);

            var result = _projekatZaGradjevinskuDozvoluService.Add(projekatZaGradjevinskuDozvolu);

            foreach (var povrsina in request.Povrsine)
            {
                povrsina.VrstaPovrsine = null;
                povrsina.ProjekatZaGradjevinskuDozvoluId = result.ResultObject.Id;
                result.ResultObject.Povrsine.Add(povrsina);
                _povrsinaService.Add(povrsina);
            }

            _mapper.Map<CreateProjekatZaGradjevinskuDozvoluResponse>(result.ResultObject);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditProjekatZaGradjevinskuDozvoluRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id < 0)
                return BadRequest(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "'id' manji od 0."));

            var projekatZaGradjevinskuDozvolu = _projekatZaGradjevinskuDozvoluService.Get(id);

            if (projekatZaGradjevinskuDozvolu == null)
                return NotFound(new ServiceResult<ProjekatZaGradjevinskuDozvolu>(false, "Projekat za gradjevinsku dozvolu nije pronadjen."));

            _mapper.Map(request, projekatZaGradjevinskuDozvolu);

            foreach (var povrsina in projekatZaGradjevinskuDozvolu.Povrsine.Where(x => x.Status != Status.None))
            {
                if (povrsina.Status == Status.Insert)
                {
                    povrsina.ProjekatZaGradjevinskuDozvoluId = projekatZaGradjevinskuDozvolu.Id;
                    _povrsinaService.Add(povrsina);
                }
                else if (povrsina.Status == Status.Update)
                {
                    _povrsinaService.Update(povrsina);
                }
                else
                {
                    _povrsinaService.Delete(povrsina);
                }
            }

            var result = _projekatZaGradjevinskuDozvoluService.Update(projekatZaGradjevinskuDozvolu);

            _mapper.Map<EditProjekatZaGradjevinskuDozvoluResponse>(result.ResultObject);

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