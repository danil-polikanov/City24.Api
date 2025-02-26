using System.Net;

namespace City24.Api.Domain.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string Type { get; set; }
        public int Rooms { get; set; } 
        public int TotalBathrooms { get; set; }
        public int TotalBedrooms { get; set; }
        public int Floor { get; set; }
        public int TotalFloors { get; set; }
        public double Area { get; set; }
        public string? Balcony { get; set; }
        public string Ownership { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public int PriceId {  get; set; }
        public Price Price { get; set; }
        public int CommunicationId {  get; set; }
        public Communications Communications {  get; set; }
        public List<Photo> Photos { get; set; } = new List<Photo>();
        public List<SecuritySystem> SecuritySystems { get; set; } = new List<SecuritySystem>();
        public List<Feature> Features { get; set; } = new List<Feature>();
    }
}
