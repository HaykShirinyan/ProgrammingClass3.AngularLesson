﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ProductType>> GetAllAsync()
        {
            return await _dbContext.ProductTypes.ToListAsync();
        }

        public async Task<ProductType> GetAsync(int id)
        {
            return await _dbContext.ProductTypes.FindAsync(id);
        }

        public async Task<ProductType> AddAsync(ProductType productType)
        {
            _dbContext.ProductTypes.Add(productType);
            await _dbContext.SaveChangesAsync();

            return productType;
        }

        public async Task<ProductType> UpdateAsync(ProductType productType)
        {
            _dbContext.Update(productType);
            await _dbContext.SaveChangesAsync();

            return productType;
        }

        public async Task<ProductType> DeleteAsync(int id)
        {
            var productType = await _dbContext.ProductTypes.FindAsync(id);
            if(productType != null)
            {
                _dbContext.Remove(productType);
                await _dbContext.SaveChangesAsync();

                return productType;
            }

            return null;
        }
    }
}
