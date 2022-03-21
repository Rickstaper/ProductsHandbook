using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Contracts
{
    public interface IRepositoryManager
    {
        IPriceRepository GetPriceRepository();
        IProductRepository GetProductRepository();
        Task SaveAsync();
    }
}
