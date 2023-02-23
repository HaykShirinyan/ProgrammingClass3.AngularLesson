using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private Data.IProductTypeRepository _dbContext;

        public ProductRepository(Data.IProductTypeRepository dbContext)
        {
            _dbContext = dbContext;
        }   

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product Get(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public Product Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return product;
        }

        public Product Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();

            return product;
        }

        public Product Delete(int id)
        {
            var product = _dbContext.Products.Find(id);

            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();

                return product;
            }

            return null;
        }
    }
}
