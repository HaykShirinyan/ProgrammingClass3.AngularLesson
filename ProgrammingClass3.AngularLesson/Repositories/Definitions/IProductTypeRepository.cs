using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositories.Definitions
{
    public interface IProductTypeRepository
    {
        Task<List<ProductType>> GetAllAsync();

        Task<ProductType> GetAsync(int id);

        Task<ProductType> AddAsync(ProductType productType);

        Task<ProductType> UpdateAsync(ProductType productType);

        Task<ProductType> DeleteAsync(int id);
    }
}
