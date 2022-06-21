using AutoMapper;
using cqrs_mediatr.Domain.Commands.Requests;
using cqrs_mediatr.Domain.Commands.Responses;
using cqrs_mediatr.Entities;
using cqrs_mediatr.Repositories;
using MediatR;

namespace cqrs_mediatr.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly CustomersRepository _customersRepository;
        private readonly IMapper _mapper;

        public CreateCustomerHandler(CustomersRepository customersRepository, IMapper mapper)
        {
            _customersRepository = customersRepository;
            _mapper = mapper;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<CreateCustomerResponse>(
                await _customersRepository.CreateAsync(_mapper.Map<Customer>(request)));
        }
    }
}