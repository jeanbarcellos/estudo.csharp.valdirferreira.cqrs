using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Requests;
using WebMediator.Domain.Commands.Responses;

namespace WebMediator.Domain.Handlers
{
    public class ProductInsertHandler : IRequestHandler<ProductRequest, ProductResponse>
    {
        public Task<ProductResponse> Handle(ProductRequest request, CancellationToken cancellationToken)
        {
            var result = new ProductResponse
            {
                Id = Guid.NewGuid(),
                Name = "Iphone XR",
                Value = 4000,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
