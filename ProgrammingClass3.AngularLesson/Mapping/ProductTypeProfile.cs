using AutoMapper;
using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Mapping
{
    public class ProductTypeProfile : Profile
    {
        public ProductTypeProfile()
        {
            CreateMap<ProductType, ProductTypeDto>();

            CreateMap<ProductTypeDto, ProductType>();
        }
    }
}
