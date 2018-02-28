
using System.Collections.Generic;

namespace AspCoreNetKata.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
