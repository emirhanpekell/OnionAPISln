using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryResponse
    {
        public string Description { get; internal set; }
        public decimal Discount { get; internal set; }
        public string Title { get; internal set; }
        public decimal Price { get; internal set; }
    }
}
