using Handbook.Contracts;
using Handbook.Data;
using Handbook.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Repository.ModelsRepository
{
    public class PriceRepository : RepositoryBase<Price>, IPriceRepository
    {
        public PriceRepository(HandbookContext handbookContext)
            : base(handbookContext)
        { }

        public void CreatePrice(Price entity) => Create(entity);

        public void DeletePrice(Price entity) => Delete(entity);

        public async Task<IEnumerable<Price>> GetAllPricesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .ToListAsync();

        public async Task<Price> GetPriceByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
}
