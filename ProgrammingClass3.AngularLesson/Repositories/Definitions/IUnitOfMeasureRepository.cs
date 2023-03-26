using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositories.Definitions
{
    public interface IUnitOfMeasureRepository
    {
        Task<List<UnitOfMeasure>> GetAllAsync();

        Task<UnitOfMeasure> GetAsync(int id);

        Task<UnitOfMeasure> AddAsync(UnitOfMeasure unitOfMeasure);

        Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasure);

        Task<UnitOfMeasure> DeleteAsync(int id);
    }
}
