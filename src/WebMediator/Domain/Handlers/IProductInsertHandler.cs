using WebMediator.Domain.Commands.Requests;
using WebMediator.Domain.Commands.Responses;

namespace WebMediator.Domain.Handlers
{
    public interface IProductInsertHandler
    {
        ProductResponse Handle(ProductRequest request);
    }
}
