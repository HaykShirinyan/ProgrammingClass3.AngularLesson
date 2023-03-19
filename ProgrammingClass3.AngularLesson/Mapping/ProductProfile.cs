using AutoMapper;
using ProgrammingClass3.AnguarLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Mapping
{
    public class ProductProfile : ProductProfile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductDto, Product>();
        }
    }
}