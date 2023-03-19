using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Repositories.Implementations;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class ProductTypeService : IProductTypeService
    {
        private IMapper _mapper;
        private IProductTypeRepository _repository;

        public ProductTypeService(IMapper mapper, IProductTypeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public ProductTypeDto Add(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            _repository.Add(productTypeModel);

            return productTypeDto;
        }

        public ProductTypeDto Delete(int id)
        {
            var deleted = _repository.Delete(id);

            return _mapper.Map<ProductTypeDto>(deleted);
        }

        public ProductTypeDto Get(int id)
        {
            var productType = _repository.Get(id);

            return _mapper.Map<ProductTypeDto>(productType);
        }

        public List<ProductTypeDto> GetAll()
        {
            var productTypes = _repository.GetAll();

            return _mapper.Map<List<ProductTypeDto>>(productTypes);
        }

        public ProductTypeDto Update(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            _repository.Update(productTypeModel);

            return productTypeDto;
        }
    }
}
