using Handoff.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handoff.API.DataAccess
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
