using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data.Migrations;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasuresController : ControllerBase
    {
        private IUnitOfMeasureService _unitOfMeasureService;

        public UnitOfMeasuresController(IUnitOfMeasureService unitOfMeasureService)
        {
            _unitOfMeasureService = unitOfMeasureService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var unitOfMeasures = _unitOfMeasureService.GetAll();

            return Ok(unitOfMeasures);
        }

        [HttpGet("id")]
        public IActionResult GetUnitOfMeasurres(int id)
        {
            var unitOfMeasure = _UnitOfMeasureService.Get(id);

            if (unitOfMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitOfMeasure);
        }

        [HttpPost]
        public IActionResult AddUnitOfMeasure(UnitOfMeasure unitOfMeasure)
        {
            _unitOfMeasureService.Add(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUnitOfMeasure(int id, UnitOfMeasure unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _unitOfMeasureService.Update(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUnitOfMeasureService(int id)
        {
            var unitOfMeasure = _unitOfMeasureService.Delete(id);

            if (unitOfMeasure != null)
            {
                return Ok(unitOfMeasure);
            }                
            
            return NotFound();
        }
    }
}