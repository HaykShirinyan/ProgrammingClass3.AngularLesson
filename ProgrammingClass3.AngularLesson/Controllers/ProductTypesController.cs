using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Controllers
{
    [Route("api/product-types")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IMapper _mapper;

        public ProductTypesController(IProductTypeRepository productTypeRepository, IMapper mapper)
        {
            _productTypeRepository = productTypeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllProductTypes() 
        {
            var productTypes = _productTypeRepository.GetAll();
            var productTypeDtoList = _mapper.Map<List<ProductTypeDto>>(productTypes);

            return Ok(productTypeDtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductType(int id) 
        {
            var productType = _productTypeRepository.Get(id);

            if(productType == null) 
            {
                return NotFound();
            }

            var productTypeDto = _mapper.Map<ProductTypeDto>(productType);

            return Ok(productTypeDto);
        }

        [HttpPost]
        public IActionResult AddProductType(ProductTypeDto productType) 
        {
            var productTypeModel = _mapper.Map<ProductType>(productType);

            _productTypeRepository.Add(productTypeModel);
            
            return Ok(productType);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductTypes(int id, ProductTypeDto productType)
        {
            if (id != productType.Id)
            {
                return BadRequest("ID in the request body must be equal to ID in the URL.");
            }
            var productTypeModel = _mapper.Map<ProductType>(productType);

            _productTypeRepository.Update(productTypeModel);

            return Ok(productType);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductType(int id) 
        {
            var deleteProductType = _productTypeRepository.Delete(id);

            if (deleteProductType != null)
            {
                var productTypeDto = _mapper.Map<ProductTypeDto>(deleteProductType);

                return Ok(productTypeDto);
            }

            return NotFound();
        }
    }
}
