using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Requests;
using WebMediator.Domain.Commands.Responses;

namespace WebMediator.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public async Task<ProductResponse> Insert(
            [FromServices] IMediator mediator,
            [FromBody] ProductRequest request
        )
        {
            return await mediator.Send(request);
        }
    }
}
