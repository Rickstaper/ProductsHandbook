using Handbook.Contracts;
using Handbook.Data;
using Handbook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Repository.ModelsRepository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(HandbookContext handbookContext)
            : base(handbookContext)
        { }
    }
}
