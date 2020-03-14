namespace TomsRepairShop.Domain.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public int PersonId { get; set; }
        public string Number { get; set; }
    }
}