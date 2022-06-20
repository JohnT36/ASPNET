using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public IEnumerable<Product> GetAllProducts();
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }
}
