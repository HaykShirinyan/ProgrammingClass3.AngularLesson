using ProgrammingClass3.AngularLesson.DataTransferObjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IUnitOfMeasureService
    {

        List<UnitOfMeasureDto> GetAll();

        UnitOfMeasureDto Get(int id);

        UnitOfMeasureDto Add(UnitOfMeasureDto unitOfMeasureDto);

        UnitOfMeasureDto Update(UnitOfMeasureDto unitOfMeasureDto);

        UnitOfMeasureDto Delete(int id);
    }
}