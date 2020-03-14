namespace TomsRepairShop.Domain.Models
{
    public class WorkOrderService
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public int ServiceId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}