using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Handoff.API.Models;

namespace Handoff.API.DataAccess
{
    public class ProductRepository : IProductRepository
    {
            string _connectionString = "Server=localhost;Database=Handoff;Trusted_Connection=True;";

            public IEnumerable<Product> GetAllProducts()
            {
                using (var db = new SqlConnection(_connectionString))
                {
                    var sql = "Select * from Product;";
                    var products = db.Query<Product>(sql);
                    return products;
                }
            }

        public IEnumerable<Product> GetProductsByCategory(string categoryName)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = "Select * from Product;";
                var param = "CategoryName = categoryName";
                var products = db.Query<Product>(sql,param);
                return products;
            }
        }
    }
    }
