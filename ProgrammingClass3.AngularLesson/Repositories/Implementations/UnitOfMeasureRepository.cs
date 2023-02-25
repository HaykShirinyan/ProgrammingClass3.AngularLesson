using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Repositories.Implementations
{
    public class UnitOfMeasureRepository: IUbitOfMeasureRepository
    {
        private ApplicationDbContext _dbContext;

        public UnitOfMeasureRepository(ApplicationDbContext dbContext)
        {
              _dbContext = dbContext;
        }

        public UnitOfMeasure Add(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasure.Add(unitOfMeasure);
            _dbContext.SaveChanges();

            return unitOfMeasure;
        }

        public UnitOfMeasure Delete(int id)
        {
            var unitOfMeasure = _dbContext.UnitOfMeasure.Find(id);

            if (unitOfMeasure != null)
            {
                _dbContext.UnitOfMeasure.Remove(unitOfMeasure);
                _dbContext.SaveChanges();

                return unitOfMeasure;
            }

            return null;
        }

        public UnitOfMeasure Get(int id)
        {
            return _dbContext.UnitOfMeasure.Find(id);
        }

        public List<UnitOfMeasure> GetAll()
        {
            return _dbContext.UnitOfMeasure.ToList();
        }

        public UnitOfMeasure Update(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasures.Update(unitOfMeasure);
            _dbContext.SaveChanges();

            return unitOfMeasure;
        }
    }
}