using Microsoft.EntityFrameworkCore;
using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Repositories.Implementations
{
    public class UnitOfMeasureRepository: IUnitOfMeasureRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public UnitOfMeasureRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UnitOfMeasure>> GetAllAsync()
        {
            return await _dbContext.UnitOfMeasures.ToListAsync();
        }

        public async Task<UnitOfMeasure> GetAsync(int id)
        {
            return await _dbContext.UnitOfMeasures.FindAsync(id);
        }

        public async Task<UnitOfMeasure> AddAsync(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasures.Add(unitOfMeasure);
            await _dbContext.SaveChangesAsync();

            return unitOfMeasure;
        }

        public async Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasures.Update(unitOfMeasure);
            await _dbContext.SaveChangesAsync();

            return unitOfMeasure;
        }

        public async Task<UnitOfMeasure> DeleteAsync(int id)
        {
            var unitOfMeasure = _dbContext.UnitOfMeasures.Find(id);

            if (unitOfMeasure != null)
            {
                _dbContext.UnitOfMeasures.Remove(unitOfMeasure);
                await _dbContext.SaveChangesAsync();

                return unitOfMeasure;
            }

            return null;
        }
    }
}
