namespace City24.Api.Domain.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
