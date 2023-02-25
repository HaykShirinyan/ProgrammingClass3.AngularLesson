using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositeries.Definitions
{
    public interface IProductTypeRepository
    {
        List<ProductType> GetAll();

        ProductType Get(int id);

        ProductType Add(ProductType productType);

        ProductType Update(ProductType productType);

        ProductType Delete(int id);
    }
}