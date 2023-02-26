using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;


namespace ProgrammingClass3.AngularLesson.Repositories.Implementations
{
    public class UnitOfMeasureRepository : IUnitOfMeasureRepository
    {
        private ApplicationDbContext _dbContext;

        public UnitOfMeasureRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Models.UnitOfMeasure> GetAll()
        {
            return _dbContext.UnitOfMeasures.ToList();
        }

        public UnitOfMeasure Get(int id)
        {
            return _dbContext.UnitOfMeasures.Find(id);
        }

        public UnitOfMeasure Add(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasures.Add(unitOfMeasure);
            _dbContext.SaveChanges();

            return unitOfMeasure;
        }
        public UnitOfMeasure Update(UnitOfMeasure unitOfMeasure)
        {
            _dbContext.UnitOfMeasures.Update(unitOfMeasure);
            _dbContext.SaveChanges();

            return unitOfMeasure;
        }

        public UnitOfMeasure Delete(int id)
        {
            var unitOfMeasure = _dbContext.UnitOfMeasures.Find(id);

            if (unitOfMeasure != null)
            {
                _dbContext.UnitOfMeasures.Remove(unitOfMeasure);
                _dbContext.SaveChanges();

                return unitOfMeasure;
            }

            return null;
        }
    }
} 
