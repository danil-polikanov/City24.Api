namespace City24.Api.Domain.Entities
{
    public class BathroomInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Plate {  get; set; }
        public string VentilationType {  get; set; }

        public List<Utilities> Utilities { get; set; } = new List<Utilities>();
    }
}
