namespace City24.Api.Domain.Entities
{
    public abstract class Price
    {
        public int Id {  get; set; }
        public int FullPrice {  get; set; }
        public double CubicMetrePrice {  get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
