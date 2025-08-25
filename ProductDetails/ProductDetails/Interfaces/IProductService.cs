using ProductDetails.Models;

namespace ProductDetails.Interfaces
{
    public interface IProductService
    {
        
        Task CreateProductAsync(Product product);
        Task UpdateProductAsync(int product);
        Task DeleteProductAsync(int product);
        Task<IEnumerable<Product>> GetProducts();
    }
}
