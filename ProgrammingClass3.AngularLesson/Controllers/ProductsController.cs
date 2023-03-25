using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product= _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.Add(product);
            
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

           _productService.Update(product);

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var deletedproduct = _productService.Delete(id);

            if (deletedproduct != null)
            {
                return Ok(deletedproduct);                                                              
            }

            return NotFound();
        }
    }
}
