using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositories.Definitions
{
    public interface IUnitOfMeasureRepository
    {
        List<UnitOfMeasure> GetAll();

        UnitOfMeasure Get(int id);

        UnitOfMeasure Add(UnitOfMeasure unitOfMeasure);

        UnitOfMeasure Update(UnitOfMeasure unitOfMeasure);

        UnitOfMeasure Delete(int id);
    }
}
