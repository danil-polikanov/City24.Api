namespace City24.Api.Domain.Entities
{
    public class Utilities
    {
        public int Id { get; set; }
        public string? HeatingSystem {  get; set; }
        public string? EnergyType { get; set; }
        public List<BathroomInfo> BathroomInfo { get; set; } = new List<BathroomInfo>;
    }
}
