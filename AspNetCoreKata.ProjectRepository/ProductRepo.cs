using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                return conn.Query<Product>("SELECT Name, ProductId as Id FROM Product");
            }
        }

        public Product GetProductWithId(int id)
        {
            using (var conn = _connection)
            {
                conn.Open();
                return conn.Query<Product>("SELECT Name, ProductId as Id FROM Product where ProductId= @id", new { id })
                    .FirstOrDefault();
            }
        }

        public void UpdateProduct(Product prod)
        {
            using (var conn = _connection)
            {
                conn.Open();
                conn.Execute("UPDATE product SET Name = @name WHERE ProductId = @id",
                    new { id = prod.Id, name = prod.Name });
            }
        }

        public void DeleteProductWithId(int id)
        {
            using (var conn = _connection)
            {
                conn.Open();
                conn.Execute("DELETE FROM product WHERE ProductId=@id", new {id});
            }
        }
    }
}
