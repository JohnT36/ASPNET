using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public Product GetProduct(int id);
        public IEnumerable<Product> GetAllProducts();
    }
}
