namespace City24.Api.Domain.Entities
{
    public class BathroomInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CommunicationsId {  get; set; }
        public Communications Communications { get; set; }
    }
}
