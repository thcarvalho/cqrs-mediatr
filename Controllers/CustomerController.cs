using cqrs_mediatr.Domain.Commands.Requests;
using cqrs_mediatr.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace cqrs_mediatr.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateCustomerResponse> PostAsync([FromBody] CreateCustomerRequest command)
        {
            return await _mediator.Send(command);
        }
    }
}