using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data.Migrations;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Srvices.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasuresController : ControllerBase
    {
        private IUnitOfMeasureRepository _unitOfMeasureRepository;

        public UnitOfMeasuresController(IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var unitOfMeasures = _unitOfMeasureRepository.GetAll();

            return Ok(unitOfMeasures);
        }

        [HttpGet("id")]
        public IActionResult GetUnitOfMeasurres(int id)
        {
            var unitOfMeasure = _UnitOfMeasureRepository.Get(id);

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
        public IActionResult DeleteUnitOfMeasureRepository(int id)
        {
            var unitOfMeasure = _unitOfMeasureRepository.Delete(id);

            if (unitOfMeasure != null)
            {
                return Ok(unitOfMeasure);
            }                
            
            return NotFound();
        }
    }
}