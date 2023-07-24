using food_facts.Models;
using food_facts.Service;

namespace food_facts.Service
{
    public class foodfactService : IfoodfactService
    {
        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        
    }
}