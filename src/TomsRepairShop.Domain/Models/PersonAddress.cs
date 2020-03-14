namespace TomsRepairShop.Domain.Models
{
    public class PersonAddress
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string AdressName { get; set; }
        public string RecipientName { get; set; }
        public string AddressLineOne { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
    }
}