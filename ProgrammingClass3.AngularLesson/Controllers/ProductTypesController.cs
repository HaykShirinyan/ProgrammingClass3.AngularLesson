using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [ApiController]
    [Route("api/product-types")]
    public class ProductTypesController : ControllerBase
    {
        private IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public IActionResult GetAllProductTypes()
        {
            var productTypes = _productTypeService.GetAll();

            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductType(int id)
        {
            var productType = _productTypeService.Get(id);

            if (productType == null)
            {
                return NotFound();
            }

            return Ok(productType);
        }

        [HttpPost]
        public IActionResult AddProductType(ProductTypeDto productType)
        {
            _productTypeService.Add(productType);

            return Ok(productType);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductType(int id, ProductTypeDto productType)
        {
            if (id != productType.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

            _productTypeService.Update(productType);

            return Ok(productType);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductType(int id)
        {
            var productType = _productTypeService.Delete(id);

            if (productType != null)
            {
                return Ok(productType);
            }

            return NotFound();
        }
    }
}
