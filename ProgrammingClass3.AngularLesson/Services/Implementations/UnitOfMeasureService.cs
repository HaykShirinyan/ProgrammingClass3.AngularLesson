using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;
using ProgrammingClass3.AngularLesson.Services.Definitions;

namespace ProgrammingClass3.AngularLesson.Services.Implementations
{
    public class UnitOfMeasureService : IUnitOfMeasureService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        
        public UnitOfMeasureService(IMapper mapper, IUnitOfMeasureRepository unitPfMeasureRepository)
        {
            _mapper = mapper;
            _unitOfMeasureRepository = unitPfMeasureRepository;
        }

        public List<UnitOfMeasureDto> GetAll()
        {
            var unitofmeasures = _unitOfMeasureRepository.GetAll();
            return _mapper.Map<UnitOfMeasureDto>>(unitofmeasures);
        }

        public UnitOfMeasureDto Get (int id)
        {
            var unitofmeasure = _unitOfMeasureRepository.GetAll();
            return _mapper.Map<UnitOfMeasureDto>(unitofmeasure);
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

        public UnitOfMeasureDto Delete (int id)
        {
            var deleted = _unitOfMeasureRepository.Delete(id);
            return _mapper.Map<UnitOfMeasureDto>(deleted);
        }
    }
}