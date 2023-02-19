using ProgrammingClass3.AngularLesson.Models;

namespace ProgrammingClass3.AngularLesson.Repositories.Definitions
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product Get(int id);

        Product Add(Product product);

        Product Update(Product product);

        Product Delete(int id);
    }
}
