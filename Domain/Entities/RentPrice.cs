namespace City24.Api.Domain.Entities
{
    public class RentPrice:Price
    {
        public string AdditionPayment {  get; set; }
        public int SummerUtility {  get; set; }
        public int WinterUtility { get; set; }
        public int Deposit {  get; set; }
        public int MaklerPrice { get; set; }
    }
}
