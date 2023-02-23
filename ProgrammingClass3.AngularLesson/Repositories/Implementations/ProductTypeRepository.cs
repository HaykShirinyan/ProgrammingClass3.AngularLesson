using ProgrammingClass3.AngularLesson.Data;
using ProgrammingClass3.AngularLesson.Models;
using ProgrammingClass3.AngularLesson.Repositories.Definitions;

namespace ProgrammingClass3.AngularLesson.Repositories.Implementations
{
    public class ProductTypeRepository: IProductTypeRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductTypeRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ProductType> GetAll()
        {
            return _dbContext.ProductTypes.ToList();
        }

        public ProductType Get(int id)
        {
            return _dbContext.ProductTypes.Find(id);
        }

        public ProductType Add(ProductType productType)
        {
            _dbContext.ProductTypes.Add(productType);
            _dbContext.SaveChanges();

            return productType;
        }

        public ProductType Update(ProductType productType)
        {
            _dbContext.Update(productType);
            _dbContext.SaveChanges();

            return productType;
        }

        public ProductType Delete(int id)
        {
            var productType = _dbContext.ProductTypes.Find(id);
            if(productType != null)
            {
                _dbContext.Remove(productType);
                _dbContext.SaveChanges();

                return productType;
            }

            return null;
        }
    }
}
