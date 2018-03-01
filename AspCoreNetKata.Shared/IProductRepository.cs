
using System.Collections.Generic;

namespace AspCoreNetKata.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductWithId(int id);
        void UpdateProduct(Product prod);
    }
}
