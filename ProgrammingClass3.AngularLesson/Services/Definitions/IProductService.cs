using ProgrammingClass3.AngularLesson.DataTransferObjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllAsync();

        Task<ProductDto> GetAsync(int id);

        Task<ProductDto> AddAsync(ProductDto productDto);

        Task<ProductDto> UpdateAsync(ProductDto productDto);

        Task<ProductDto> DeleteAsync(int id);
    }
}
