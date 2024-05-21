using OnionAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
        }

        public Product(string title, string description, int brandId, decimal price, decimal discount, Brand brand, ICollection<Category> category)
        {
            Title = title;
            Description = description;
            BrandId = brandId;
            Price = price;
            this.discount = discount;
            Brand = brand;
          
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal discount { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
