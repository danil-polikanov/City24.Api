namespace City24.Api.Domain.Entities
{
    public class Communications
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Utilities> Utilities { get; set; } = new List<Utilities>();
    }
}
