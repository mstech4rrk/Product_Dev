using ProductDetails.Models;

namespace ProductDetails.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<Product>> Products();
        Task<bool> SaveChangesAsync(Product product);
        Task CreateProduct(Product product);
        Task DeleteProduct(int id);
        Task UpdateProduct(int id);
    }
}
