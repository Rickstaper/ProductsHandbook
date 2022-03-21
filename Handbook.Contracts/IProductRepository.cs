using Handbook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts(bool trackChanges);
        Task<Product> GetProductById(Guid id, bool trackChanges);
        void CreateProduct(Product entity);
        void DeleteProduct(Product entity);
    }
}
