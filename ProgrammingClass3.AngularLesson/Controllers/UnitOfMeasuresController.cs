using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data.Migrations;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/unitofmeasures")]
    [ApiController]
    public class UnitOfMeasuresController : ControllerBase
    {
        private IUnitOfMeasureRepository _unitOfMeasuresRepository;

        public UnitOfMeasuresController(IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfMeasuresRepository = unitOfMeasureRepository;
        }

        [HttpGet]
        public IActionResult GetAllUnitOfMeasure()
        {
            var unitOfMeasures = _unitOfMeasuresRepository.GetAll();

            return Ok(unitOfMeasures);
        }

        [HttpGet("{id}")]
        public IActionResult GetUnitOfMeasure(int id)
        {
            var unitOfMeasure = _unitOfMeasuresRepository.Get(id);

            if (unitOfMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitOfMeasure);
        }

        [HttpPost]
        public IActionResult AddUnitOfMeasure(UnitOfMeasure unitOfMeasure)
        {
            _unitOfMeasuresRepository.Add(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUnitOfMeasure(int id, UnitOfMeasure unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _unitOfMeasuresRepository.Update(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUnitOfMeasure(int id)
        {
            var deleteUnitOfMeasure = _unitOfMeasuresRepository.Delete(id);

            if (deleteUnitOfMeasure != null)
            {
                return Ok(deleteUnitOfMeasure);
            }

            return NotFound();
        }
    }
}
