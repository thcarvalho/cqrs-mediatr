namespace cqrs_mediatr.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        
        
    }
}