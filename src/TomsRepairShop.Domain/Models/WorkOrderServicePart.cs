namespace TomsRepairShop.Domain.Models
{
    public class WorkOrderServicePart
    {
        public int Id { get; set; }
        public int WorkOrderServiceId { get; set; }
        public int PartId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}