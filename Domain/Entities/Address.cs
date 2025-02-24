namespace City24.Api.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; } 
        public string District { get; set; } 
        public string PostalCode { get; set; } 
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();
    }

}
