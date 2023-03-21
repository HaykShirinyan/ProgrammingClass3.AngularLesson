using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class UnitOfMeasureService: IUnitOfMeasureService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;

        public UnitOfMeasureService(IMapper mapper, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<List<UnitOfMeasureDto>> GetAllAsync()
        {
            var unitOfMeasures = await _unitOfMeasureRepository.GetAllAsync();
            return _mapper.Map<List<UnitOfMeasureDto>>(unitOfMeasures);
        }

        public async Task<UnitOfMeasureDto> GetAsync(int id)
        {
            var unitOfMeasure =await _unitOfMeasureRepository.GetAsync(id);
            return _mapper.Map<UnitOfMeasureDto>(unitOfMeasure);
        }

        public async Task<UnitOfMeasureDto> AddAsync(UnitOfMeasureDto unitOfMeasureDto)
        {
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasureDto);

            await _unitOfMeasureRepository.AddAsync(unitOfMeasureModel);

            return unitOfMeasureDto;
        }

        public async Task<UnitOfMeasureDto> UpdateAsync(UnitOfMeasureDto unitOfMeasureDto)
        {
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasureDto);

            await _unitOfMeasureRepository.UpdateAsync(unitOfMeasureModel);

            return unitOfMeasureDto;
        }

        public async Task<UnitOfMeasureDto> DeleteAsync(int id)
        {
            var deleted =await _unitOfMeasureRepository.DeleteAsync(id);
            return _mapper.Map<UnitOfMeasureDto>(deleted);
        }
    }
}
