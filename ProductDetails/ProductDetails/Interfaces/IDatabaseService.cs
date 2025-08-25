using ProductDetails.Models;

namespace ProductDetails.Interfaces
{
    public interface IDatabaseService
    {
        Task<bool> InsertProduct();
        Task<bool> UpdateProduct();
        Task<bool> DeleteProduct();
        Task<IEnumerable<Product>> GetProducts();
    }
}