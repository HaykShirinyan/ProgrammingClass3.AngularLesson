using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Repositories.Implementations;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/product-Types")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private IProductTypeRepository _productTypeRepository;

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
        public IActionResult GetProductTypes(int id)
        {
            var productTypes = _productTypeRepository.Get(id);

            if (productTypes == null)
            {
                return NotFound();
            }

            return Ok(productTypes);
        }

        [HttpPost]
        public IActionResult AddProductTypes(ProductType productType)
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
            var deletedproductType = _productTypeRepository.Delete(id);

            if (deletedproductType != null)
            {
                return Ok(deletedproductType);
            }

            return NotFound();
        }
    }
}
