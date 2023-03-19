using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IMapper _mapper;
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeService(IMapper mapper, IProductTypeRepository productTypeRepository)
        {
            _mapper = mapper;
            _productTypeRepository = productTypeRepository;
        }

        public List<ProductTypeDto> GetAll()
        {
            var producttypes = _productTypeRepository.GetAll();
            return _mapper.Map<List<ProductTypeDto>>(producttypes);
        }

        public ProductTypeDto Get(int id)
        {
            var producttype = _productTypeRepository.Get(id);
            return _mapper.Map<ProductTypeDto>(producttype);
        }

        public ProductTypeDto Add(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            _productTypeRepository.Add(productTypeModel);

            return productTypeDto;
        }

        public ProductTypeDto Update(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            _productTypeRepository.Update(productTypeModel);

            return productTypeDto;
        }

        public ProductTypeDto Delete(int id)
        {
            var deleted = _productTypeRepository.Delete(id);
            return _mapper.Map<ProductTypeDto>(deleted);
        }
    }
}
