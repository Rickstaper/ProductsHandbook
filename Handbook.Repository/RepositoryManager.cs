using Handbook.Contracts;
using Handbook.Data;
using Handbook.Repository.ModelsRepository;
using System.Threading.Tasks;

namespace Handbook.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private HandbookContext _handbookContext;
        private IProductRepository _productRepository;
        private IPriceRepository _priceRepository;

        public RepositoryManager(HandbookContext handbookContext)
        {
            _handbookContext = handbookContext;
        }

        public IPriceRepository GetPriceRepository()
        {
            if(_priceRepository == null)
            {
                _priceRepository = new PriceRepository(_handbookContext);
            }

            return _priceRepository;
        }

        public IProductRepository GetProductRepository()
        {
            if(_productRepository == null)
            {
                _productRepository = new ProductRepository(_handbookContext);
            }

            return _productRepository;
        }

        public async Task SaveAsync() => await _handbookContext.SaveChangesAsync();
    }
}
