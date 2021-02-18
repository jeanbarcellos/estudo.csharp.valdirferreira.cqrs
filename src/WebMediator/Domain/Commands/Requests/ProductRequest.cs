using MediatR;
using WebMediator.Domain.Commands.Responses;

namespace WebMediator.Domain.Commands.Requests
{
    public class ProductRequest : IRequest<ProductResponse>
    {
        public string Name { get; set; }
        public decimal Valor { get; set; }
    }
}
