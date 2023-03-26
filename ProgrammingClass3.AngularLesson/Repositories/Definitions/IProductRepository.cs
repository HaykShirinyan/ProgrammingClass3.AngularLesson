using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositories.Definitions
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();

        Task<Product> GetAsync(int id);

        Task<Product> AddAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<Product> DeleteAsync(int id);
    }
}
