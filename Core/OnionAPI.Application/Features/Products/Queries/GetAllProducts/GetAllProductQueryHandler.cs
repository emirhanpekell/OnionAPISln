using MediatR;
using OnionAPI.Application.Interfaces.UnitofWorks;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, IList<GetAllProductQueryResponse>>
    {
        private readonly IUnitofWork _unitOfWork;

        public GetAllProductQueryHandler(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();
            List<GetAllProductQueryResponse> response = new();

            foreach (var product in products) 
                response.Add(new GetAllProductQueryResponse
                {
                    Title = product.Title,
                    Description = product.Description,
                    Discount = product.discount,
                    Price = product.Price - (product.Price * product.discount/100)
                });

            
            return response;
        }
    }
}
