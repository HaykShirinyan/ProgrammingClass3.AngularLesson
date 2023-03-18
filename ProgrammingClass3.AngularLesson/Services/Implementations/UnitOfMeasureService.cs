using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class UnitOfMeasureService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;

        public UnitOfMeasureService(IMapper mapper, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public List<UnitOfMeasureDto> GetAll()
        {
            var unitOfMeasures = _unitOfMeasureRepository.GetAll();
            return _mapper.Map<List<UnitOfMeasureDto>>(unitOfMeasures);
        }

        public UnitOfMeasureDto Get(int id)
        {
            var unitOfMeasure = _unitOfMeasureRepository.Get(id);
            return _mapper.Map<UnitOfMeasureDto>(unitOfMeasure);
        }

        public UnitOfMeasureDto Add(UnitOfMeasureDto unitOfMeasureDto)
        {
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasureDto);

            _unitOfMeasureRepository.Add(unitOfMeasureModel);

            return unitOfMeasureDto;
        }

        public UnitOfMeasureDto Update(UnitOfMeasureDto unitOfMeasureDto)
        {
            var unitOfMeasureModel = _mapper.Map<UnitOfMeasure>(unitOfMeasureDto);

            _unitOfMeasureRepository.Update(unitOfMeasureModel);

            return unitOfMeasureDto;
        }

        public UnitOfMeasureDto Delete(int id)
        {
            var deleted = _unitOfMeasureRepository.Delete(id);
            return _mapper.Map<UnitOfMeasureDto>(deleted);
        }
    }
}
