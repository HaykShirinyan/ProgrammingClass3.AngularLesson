using ProgrammingClass3.AngularLesson.DataTransferObjects;

namespace ProgrammingClass3.AngularLesson.Services.Definitions
{
    public interface IProductTypeService
    {
        List<ProductTypeDto> GetAll();

        ProductTypeDto Get(int id);

        ProductTypeDto Add (ProductTypeDto productTypeDto);

        ProductTypeDto Update (ProductTypeDto productTypeDto);

        ProductTypeDto Delete (int id);
    }
}
