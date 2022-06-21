using cqrs_mediatr.Domain.Commands.Responses;
using MediatR;

namespace cqrs_mediatr.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Email { get; set; }
        public string Name { get; set; }   
    }
}