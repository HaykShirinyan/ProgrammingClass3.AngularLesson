using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.DataTransferOgjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class ProductService : IproductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public List<ProductDto> GetAll()
        {
            var products = _productRepository.GetAll();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDto Get(int id)
        {
            var product = _productRepository.Get(id);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto Add(ProductDto productDto)
        {
            var productModel = _mapper.Map<Product>(productDto);

            _productRepository.Add(productModel);

            return productDto;
        }

        public ProductDto Update(ProductDto productDto)
        {
            var productModel = _mapper.Map<Produc>(productDto);

            _productRepository.Update(productModel);

            return productDto;
        }

        public ProductDto Delete(int id)
        {
            var deleted = _productRepository.Delete(id);
            return _mapper.Map<ProductDto>(deleted);
        }
    }
}