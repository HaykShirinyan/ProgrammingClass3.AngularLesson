using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var product = await _productRepository.GetAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            var productModel = _mapper.Map<Product>(productDto);

            await _productRepository.AddAsync(productModel);

            return productDto;
        }

        public async Task<ProductDto> UpdateAsync(ProductDto productDto)
        {
            var productModel = _mapper.Map<Product>(productDto);

            await _productRepository.UpdateAsync(productModel);

            return productDto;
        }

        public async Task<ProductDto> DeleteAsync(int id)
        {
            var deleted = await _productRepository.DeleteAsync(id);
            return _mapper.Map<ProductDto>(deleted);
        }
    }
}
