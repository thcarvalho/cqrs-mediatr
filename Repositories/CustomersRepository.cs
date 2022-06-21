using cqrs_mediatr.Entities;

namespace cqrs_mediatr.Repositories
{
    public class CustomersRepository
    {
        public async Task<Customer> CreateAsync(Customer customer)
        {
            customer.CreatedAt = DateTime.Now;
            customer.Id = Guid.NewGuid();
            return customer;
        }
    }
}