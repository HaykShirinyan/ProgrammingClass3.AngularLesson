using ProgrammingClass3.AngularLesson.DataTransferObjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IProductTypeService
    {
        Task<List<ProductTypeDto>> GetAllAsync();

        Task<ProductTypeDto> GetAsync(int id);

        Task<ProductTypeDto> AddAsync(ProductTypeDto productTypeDto);

        Task<ProductTypeDto> UpdateAsync(ProductTypeDto productTypeDto);

        Task<ProductTypeDto> DeleteAsync(int id);
    }
}
