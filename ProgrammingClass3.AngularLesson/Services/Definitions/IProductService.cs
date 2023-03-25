using ProgrammingClass3.AngularLesson.DataTransferObjects;
using ProgrammingClass3.AngularLesson.DataTransferOgjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IproductService
    {
        List<ProductDto> GetAll();

        ProductDto Get(int id);

        ProductDto Add(ProductDto productDto);

        ProductDto Update(ProductDto productDto);

        ProductDto Delete(int id);
    }
}