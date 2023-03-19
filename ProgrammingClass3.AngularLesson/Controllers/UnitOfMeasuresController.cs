using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data.Migrations;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/unitofmeasures")]
    [ApiController]
    public class UnitOfMeasuresController : ControllerBase
    {
        private readonly IUnitOfMeasureService _unitOfMeasureService;

        public UnitOfMeasuresController(IUnitOfMeasureService unitOfMeasureService)
        {
            _unitOfMeasureService = unitOfMeasureService;
        }

        [HttpGet]
        public IActionResult GetAllUnitOfMeasure()
        {
            var unitOfMeasures = _unitOfMeasureService.GetAll();

            return Ok(unitOfMeasures);
        }

        [HttpGet("{id}")]
        public IActionResult GetUnitOfMeasure(int id)
        {
            var unitOfMeasure = _unitOfMeasureService.Get(id);

            if (unitOfMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitOfMeasure);
        }

        [HttpPost]
        public IActionResult AddUnitOfMeasure(UnitOfMeasureDto unitOfMeasure)
        {
            _unitOfMeasureService.Add(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUnitOfMeasure(int id, UnitOfMeasureDto unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _unitOfMeasureService.Update(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUnitOfMeasure(int id)
        {
            var deleteUnitOfMeasure = _unitOfMeasureService.Delete(id);

            if (deleteUnitOfMeasure != null)
            {
                return Ok(deleteUnitOfMeasure);
            }

            return NotFound();
        }
    }
}
