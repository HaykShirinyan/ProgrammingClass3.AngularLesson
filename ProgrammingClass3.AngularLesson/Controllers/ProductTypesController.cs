﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/product-Types")]
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
            var productTypes = _dbContext.ProductTypes.Find(id);

            if (productTypes == null)
            {
                return NotFound();
            }

            return Ok(productTypes);
        }

        [HttpPost]
        public IActionResult AddProductTypes(ProductType productType)
        {
            _dbContext.ProductTypes.Add(productType);
            _dbContext.SaveChanges();

            return Ok(productType);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductTypes(int id, ProductType productType)
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
        public IActionResult DeleteProductType(int id)
        {
            var productType = _dbContext.ProductTypes.Find(id);

            if (productType != null)
            {
                _dbContext.ProductTypes.Remove(productType);
                _dbContext.SaveChanges();

                return Ok(productType);
            }

            return NotFound();
        }
    }
}
