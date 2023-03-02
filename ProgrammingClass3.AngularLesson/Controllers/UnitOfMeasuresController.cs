using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
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

        public UnitOfMeasuresController(IUnitOfMeasureRepository unitOfMeasureRepository) 
        {
             _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        [HttpGet]
        public IActionResult GetAllUnitOfMeasures()
        {
            var unitOfMeasures = _unitOfMeasureRepository.GetAll();

            return Ok(unitOfMeasures);
        }

        [HttpGet("{id}")]
        public IActionResult GetUnitOfMeasure(int id) 
        {
            var unitOfMeasure = _unitOfMeasureRepository.Get(id);

            if (unitOfMeasure == null) 
            { 
                return NotFound();
            }

            return Ok(unitOfMeasure);
        }

        [HttpPost]
        public IActionResult AddUnitOfMeasure(UnitOfMeasure unitOfMeasure)
        {
            _unitOfMeasureRepository.Add(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUnitOfMeasure(int id, UnitOfMeasure unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _unitOfMeasureRepository.Update(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUnitOfMeasure(int id)
        {
            var deletedUnitOfMeasure = _unitOfMeasureRepository.Delete(id);

            if(deletedUnitOfMeasure != null)
            {
                return Ok(deletedUnitOfMeasure);
            }

            return NotFound();
        }       
    }
}
