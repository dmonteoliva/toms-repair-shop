namespace TomsRepairShop.Domain.Models
{
    public class LegalPerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string CompanyName { get; set; }
        public string TradingName { get; set; }
    }
}