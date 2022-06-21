using AutoMapper;
using cqrs_mediatr.Domain.Commands.Requests;
using cqrs_mediatr.Domain.Commands.Responses;
using cqrs_mediatr.Entities;

namespace cqrs_mediatr.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<Customer, CreateCustomerResponse>();
        }
    }
}