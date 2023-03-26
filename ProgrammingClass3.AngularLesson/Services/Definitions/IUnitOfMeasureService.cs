using ProgrammingClass3.AngularLesson.DataTransferObjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IUnitOfMeasureService
    {
        Task<List<UnitOfMeasureDto>> GetAllAsync();

        Task<UnitOfMeasureDto> GetAsync(int id);

        Task<UnitOfMeasureDto> AddAsync(UnitOfMeasureDto unitOfMeasureDto);

        Task<UnitOfMeasureDto> UpdateAsync(UnitOfMeasureDto unitOfMeasureDto);

        Task<UnitOfMeasureDto> DeleteAsync(int id);
    }
}
