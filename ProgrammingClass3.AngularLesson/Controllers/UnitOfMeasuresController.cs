using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Repositories.Implementations;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/unit-of-measures")]
    [ApiController]
    public class UnitOfMeasuresController : ControllerBase
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IMapper _mapper;

        public UnitOfMeasuresController(IUnitOfMeasureRepository unitOfMeasureRepository, IMapper mapper) 
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllUnitOfMeasures()
        {
            var unitOfMeasures = _unitOfMeasureRepository.GetAll();
            var unitOfMeasureDtoList = _mapper.Map<List<UnitOfMeasureDto>>(unitOfMeasures);

            return Ok(unitOfMeasureDtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetUnitOfMeasure(int id) 
        {
            var unitOfMeasure = _unitOfMeasureRepository.Get(id);

            if (unitOfMeasure == null) 
            { 
                return NotFound();
            }

            var unitOfMeasureDto = _mapper.Map<UnitOfMeasureDto>(unitOfMeasure);

            return Ok(unitOfMeasureDto);
        }

        [HttpPost]
        public IActionResult AddUnitOfMeasure(UnitOfMeasureDto unitOfMeasure)
        {
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasure);

            _unitOfMeasureRepository.Add(unitOfMeasureModel);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUnitOfMeasure(int id, UnitOfMeasureDto unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasure);

            _unitOfMeasureRepository.Update(unitOfMeasureModel);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUnitOfMeasure(int id)
        {
            var deletedUnitOfMeasure = _unitOfMeasureRepository.Delete(id);

            if(deletedUnitOfMeasure != null)
            {
                var unitOfMeasureDto = _mapper.Map<UnitOfMeasureDto>(deletedUnitOfMeasure);

                return Ok(unitOfMeasureDto);
            }

            return NotFound();
        }       
    }
}
