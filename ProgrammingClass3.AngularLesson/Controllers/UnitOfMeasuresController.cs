using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [ApiController]
    [Route("api/unit-of-measures")]
    public class UnitOfMeasuresController : ControllerBase
    {
        private IUnitOfMeasureService _unitOfMeasureService;

        public UnitOfMeasuresController(IUnitOfMeasureService unitOfMeasureService)
        {
            _unitOfMeasureService = unitOfMeasureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUnitOfMeasuresAsync()
        {
            var unitOfMeasures = await _unitOfMeasureService.GetAllAsync();

            return Ok(unitOfMeasures);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitOfMeasureAsync(int id)
        {
            var unitOfMeasure = await _unitOfMeasureService.GetAsync(id);

            if (unitOfMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitOfMeasure);
        }

        [HttpPost]
        public async Task<IActionResult> AddUnitOfMeasureAsync(UnitOfMeasureDto unitOfMeasure)
        {
            await _unitOfMeasureService.AddAsync(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUnitOfMeasureAsync(int id, UnitOfMeasureDto unitOfMeasure)
        {
            if (id != unitOfMeasure.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            await _unitOfMeasureService.UpdateAsync(unitOfMeasure);

            return Ok(unitOfMeasure);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitOfMeasureAsync(int id)
        {
            var unitOfMeasure = await _unitOfMeasureService.DeleteAsync(id);

            if (unitOfMeasure != null)
            {
                return Ok(unitOfMeasure);
            }

            return NotFound();
        }

    }
}
