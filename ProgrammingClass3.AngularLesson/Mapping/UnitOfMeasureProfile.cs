using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Mapping
{
    public class UnitOfMeasureProfile: Profile
    {
        public UnitOfMeasureProfile()
        {
            CreateMap<UnitOfMeasure, UnitOfMeasureDto>();

            CreateMap<UnitOfMeasureDto, UnitOfMeasure>();
        }
    }
}
