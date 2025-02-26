namespace City24.Api.Domain.Entities
{
    public class Communications
    {
        public int Id { get; set; }
        public string? HeatingSystem { get; set; }
        public string? EnergyType { get; set; }
        public string? Plate { get; set; }
        public string? VentilationType { get; set; }
        public List<BathroomInfo> BathroomInfo { get; set; } = new List<BathroomInfo>();
    }
}
