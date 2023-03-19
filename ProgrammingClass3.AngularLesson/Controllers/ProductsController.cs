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
        private IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product= _productRepository.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRepository.Add(product);
            
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }

           _productRepository.Update(product);

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var deletedproduct = _productRepository.Delete(id);

            if (deletedproduct != null)
            {
                return Ok(deletedproduct);                                                              
            }

            return NotFound();
        }
    }
}
