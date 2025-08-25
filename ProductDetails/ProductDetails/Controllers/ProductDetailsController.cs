using Microsoft.AspNetCore.Mvc;
using ProductDetails.Interfaces;
using ProductDetails.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService productservice)
        {
            _service = productservice;
        }

        [HttpGet("Get Products")]
        public async Task<IEnumerable<Product>> GetProducts() => await _service.GetProducts();


        [HttpPost("Create Product")]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            await _service.CreateProductAsync(product);
            return Ok();
        }

        [HttpPut("Update Product")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            if (product == null || product.Id == 0)
                return BadRequest();
            if (product == null)
                return NotFound();
            await _service.UpdateProductAsync(product.Id);
            return Ok();
        }

        [HttpDelete("Delete Product:{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id < 1)
                return BadRequest();
            await _service.DeleteProductAsync(id);
            return Ok();

        }
    }
}
