using System.Collections.Generic;
using Handoff.API.DataAccess;
using Handoff.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Handoff.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : FirebaseEnabledController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var repo = new ProductRepository();
            var products = repo.GetAllProducts();
            return products;
        }

       [HttpGet("category/{categoryName}")]
       public IEnumerable<Product> GetProductsByCategory(string categoryName)
       {
           var repo = new ProductRepository();
           var products = repo.GetProductsByCategory(categoryName);
           return products;
       }


    //    [HttpGet("category/id/{categoryId}")]
    //    public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
    //    {
    //        var repo = new ProductRepository();
    //        var products = repo.GetProductsByCategoryId(categoryId);
    //        return products;
    //    }

    //    [HttpGet("search/{searchTerm}")]
    //    public IEnumerable<Product> GetProductsByName(string searchTerm)
    //    {
    //        var repo = new ProductRepository();
    //        var products = repo.GetProductsByName(searchTerm);
    //        return products;
    //    }

    //    //get home page products
    //    [HttpGet("home")]
    //    public IEnumerable<Product> GetHomePageProducts()
    //    {
    //        var repo = new ProductRepository();
    //        var products = repo.GetHomePageProducts();
    //        return products;
    //    }

    //    //get products owner has available 
    //    [HttpGet("ownerPage/{id}")]
    //    public IEnumerable<Product> GetSellersAvailableProducts(int id)
    //    {
    //        var repo = new ProductRepository();
    //        var products = repo.GetSellersAvailableProducts(id);
    //        return products;
    //    }

    //    // GET api/values/5
    //    [HttpGet("item/{id}")]
    //    public Product Get(int id)
    //    {
    //        var repo = new ProductRepository();
    //        var product = repo.GetProductById(id);
    //        return product;
    //    }

    //    // POST api/values
    //    [HttpPost]
    //    public void Post([FromBody] string value)
    //    {
    //    }

    //    // PUT api/values/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] string value)
    //    {
    //    }

    //    // DELETE api/values/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    }
}
