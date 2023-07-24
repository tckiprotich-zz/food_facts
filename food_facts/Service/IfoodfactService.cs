using food_facts.Models;

namespace food_facts.Service
{
    public interface IfoodfactService
    {
        Task<List<Product>> GetProductsAsync();
        // Task<Product> GetProductAsync(string barcode);
        // Task<Product> AddProductAsync(Product product);
        // Task<Product> UpdateProductAsync(Product product);
        // Task DeleteProductAsync(string barcode);
    }
}