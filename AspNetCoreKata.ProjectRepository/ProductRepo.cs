using System;
using System.Collections.Generic;
using System.Data;
using AspCoreNetKata.Shared;
using Dapper;

namespace AspNetCoreKata.ProjectRepository
{
    public class ProductRepo : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepo(IDbConnection conn)
        {
            _connection = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            using (var conn = _connection)
            {
                conn.Open();
                return conn.Query<Product>("SELECT * FROM Product");
            }
                throw new NotImplementedException();
        }
    }
}
