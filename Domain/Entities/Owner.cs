namespace City24.Api.Domain.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Phone { get; set; } 
        public string Email { get; set; } 
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();
    }
}
