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

        public async Task<ProductTypeDto> AddAsync(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            await _repository.AddAsync(productTypeModel);

            return productTypeDto;
        }

        public async Task<ProductTypeDto> DeleteAsync(int id)
        {
            var deleted = await _repository.DeleteAsync(id);

            return _mapper.Map<ProductTypeDto>(deleted);
        }

        public async Task<ProductTypeDto> GetAsync(int id)
        {
            var productType = await _repository.GetAsync(id);

            return _mapper.Map<ProductTypeDto>(productType);
        }

        public async Task<List<ProductTypeDto>> GetAllAsync()
        {
            var productTypes = await _repository.GetAllAsync();

            return _mapper.Map<List<ProductTypeDto>>(productTypes);
        }

        public async Task<ProductTypeDto> UpdateAsync(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            await _repository.UpdateAsync(productTypeModel);

            return productTypeDto;
        }
    }
}
