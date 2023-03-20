using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/product-types")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductTypesAsync() 
        {
            var productTypes = await _productTypeService.GetAllAsync();

            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductTypeAsync(int id) 
        {
            var productType = await _productTypeService.GetAsync(id);

            if(productType == null) 
            {
                return NotFound();
            }

            return Ok(productType);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductTypeAsync(ProductTypeDto productType) 
        {
            await _productTypeService.AddAsync(productType);
            
            return Ok(productType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductTypesAsync(int id, ProductTypeDto productType)
        {
            if (id != productType.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }
            await _productTypeService.UpdateAsync(productType);

            return Ok(productType);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductTypeAsync(int id) 
        {
            var deleteProductType = await _productTypeService.DeleteAsync(id);

            if (deleteProductType != null)
            {
                return Ok(deleteProductType);
            }

            return NotFound();
        }
    }
}
