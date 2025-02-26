namespace City24.Api.Domain.Entities
{
    public class BuildingInfo
    {
        public int Id { get; set; }
        public string? CadastralNumber { get; set; }
        public string? EnergyCertificate {  get; set; }
        public string? BuildingMaterial { get; set; }
        public int YearBuilt {  get; set; }
        public bool? Elevator { get; set; }
        public string? Parking { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
