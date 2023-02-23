using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/product-types")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypesController(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }

        [HttpGet]
        public IActionResult GetAllProductTypes() 
        {
            var productTypes = _productTypeRepository.GetAll();

            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductType(int id) 
        {
            var productType = _productTypeRepository.Get(id);

            if(productType == null) 
            {
                return NotFound();
            }

            return Ok(productType);
        }

        [HttpPost]
        public IActionResult AddProductType(ProductType productType) 
        {
            _productTypeRepository.Add(productType);
            
            return Ok(productType);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductTypes(int id, ProductType productType)
        {
            if (id != productType.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _productTypeRepository.Update(productType);

            return Ok(productType);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductType(int id) 
        {
            var deleteProductType = _productTypeRepository.Delete(id);

            if (deleteProductType != null)
            {
                return Ok(deleteProductType);
            }

            return NotFound();
        }
    }
}
