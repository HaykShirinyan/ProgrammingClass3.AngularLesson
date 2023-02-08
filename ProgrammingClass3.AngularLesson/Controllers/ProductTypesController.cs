using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/[productTypes]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private ApplicationDbContext _dbContext;

        public ProductTypesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProductTypes() 
        {
            var productTypes = _dbContext.ProductTypes.ToList();

            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductTypes(int id) 
        {
            var productType = _dbContext.ProductTypes.Find(id);

            if(productType == null) 
            {
                return NotFound();
            }

            return Ok(productType);
        }

    }
}
