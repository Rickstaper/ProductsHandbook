using Handbook.Contracts;
using Handbook.Data;
using Handbook.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Handbook.Repository.ModelsRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(HandbookContext handbookContext)
            : base(handbookContext)
        { }

        public void CreateProduct(Product entity) => Create(entity);

        public void DeleteProduct(Product entity) => Delete(entity);

        public async Task<IEnumerable<Product>> GetAllProducts(bool trackChanges) =>
            await FindAll(trackChanges)
            .ToListAsync();

        public async Task<Product> GetProductById(Guid id, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
}
