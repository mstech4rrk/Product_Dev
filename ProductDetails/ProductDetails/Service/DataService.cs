using ProductDetails.Interfaces;
using ProductDetails.Models;

namespace ProductDetails.Service
{
    public class DataService : IDataService
    {

        private readonly IDatabaseService _dataService;
        public DataService(IDatabaseService dbService)
        { 
            _dataService = dbService;
        }
        public Task<IEnumerable<Product>> Products()
        {
            throw new NotImplementedException();
        }

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IDataService.Products()
        {
            return Products();
        }
    }
}
