using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handoff.API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int SportId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductTypeId { get; set; }
        public string Color { get; set; }
        public int AgeGroupId { get; set; }
        public int ProductPrice { get; set; }
        public string IsAvailable { get; set; }
        public string ProductDescription { get; set; }
        public int ProductOwnerId { get; set; }
    }
}
