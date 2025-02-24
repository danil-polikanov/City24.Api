namespace City24.Api.Domain.Entities
{
    public class SecuritySystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
