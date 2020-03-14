using System;

namespace TomsRepairShop.Domain.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int PersonVehicleId { get; set; }
        public int WorkOrderStatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPartsPrice { get; set; }
        public decimal TotalServicesPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}