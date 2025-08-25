using ProductDetails.Interfaces;
using ProductDetails.Models;

namespace ProductDetails.Service
{
    public class ProductService : IProductService   
    {
        private readonly IDataService _service;
        private readonly Task<IEnumerable<Product>> _products;
        public ProductService(IDataService dataService)
        {
            _service = dataService;
        }

        public async Task CreateProductAsync(Product product)
        {
            await _service.CreateProduct(product);
        }

        public async Task DeleteProductAsync(int productid)
        {
            var product = _service.Products().Result.Single(x => x.Id == productid);
            await _service.DeleteProduct(product.Id);
        }

        public async Task<IEnumerable<Product>> GetProducts() => await _service.Products();

        public async Task UpdateProductAsync(int productid)
        {
            var product = _service.Products().Result.Single(x => x.Id == productid);
           
            product.Name = product.Name;
            product.Description = product.Description;
            product.Price = product.Price;
            await _service.UpdateProduct(product.Id);
        }
    }
}
