using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Controllers

{
    [Route("api/controller")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private ApplicationDbContext _dbContext;

        public ProductTypesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var productTypes = _dbContext.ProductTypes.ToList();

            return Ok(productTypes);
        }

        [HttpGet("id")]
        public IActionResult GetProduct(int id)
        {
            var productType = _dbContext.ProductTypes.Find(id);

            if (productType == null)
            {
                return NotFound();
            }

            return Ok(productType);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductType productType)
        {
            _dbContext.ProductTypes.Add(productType);
            _dbContext.SaveChanges();

            return Ok(productType);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductType productType)
        {
            if (id != productType.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _dbContext.ProductTypes.Update(productType);
            _dbContext.SaveChanges();

            return Ok(productType);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var productType = _dbContext.ProductTypes.Find(id);

            if (productType!= null)
            {
                return Ok(productType);
            }

            return NotFound();
        }
    }
}