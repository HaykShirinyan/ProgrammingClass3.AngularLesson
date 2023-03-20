using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class ProductTypeService: IProductTypeService
    {
        private readonly IMapper _mapper;
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeService(IMapper mapper, IProductTypeRepository productTypeRepository)
        {
            _mapper = mapper;
            _productTypeRepository = productTypeRepository;
        }

        public async Task<List<ProductTypeDto>> GetAllAsync() 
        {
            var productTypes = await _productTypeRepository.GetAllAsync();
            return _mapper.Map<List<ProductTypeDto>>(productTypes);
        }

        public async Task<ProductTypeDto> GetAsync(int id)
        {
            var productType = await _productTypeRepository.GetAsync(id);
            return _mapper.Map<ProductTypeDto>(productType);
        }

        public async Task<ProductTypeDto> AddAsync(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            await _productTypeRepository.AddAsync(productTypeModel);

            return productTypeDto;
        }

        public async Task<ProductTypeDto> UpdateAsync(ProductTypeDto productTypeDto)
        {
            var productTypeModel = _mapper.Map<ProductType>(productTypeDto);

            await _productTypeRepository.UpdateAsync(productTypeModel);

            return productTypeDto;
        }

        public async Task<ProductTypeDto> DeleteAsync(int id) 
        {
            var deleted = await _productTypeRepository.DeleteAsync(id);
            return _mapper.Map<ProductTypeDto>(deleted);
        }
    }
}
