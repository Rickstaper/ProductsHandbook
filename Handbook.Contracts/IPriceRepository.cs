using Handbook.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Handbook.Contracts
{
    public interface IPriceRepository
    {
        Task<IEnumerable<Price>> GetAllPricesAsync(bool trackChanges);
        Task<Price> GetPriceByIdAsync(Guid id, bool trackChanges);
        void CreatePrice(Price entity);
        void DeletePrice(Price entity);
    }
}
