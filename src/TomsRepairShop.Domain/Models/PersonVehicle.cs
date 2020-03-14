namespace TomsRepairShop.Domain.Models
{
    public class PersonVehicle
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int VehicleModelId { get; set; }
        public int ColorId { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string LicencePlate { get; set; }
        public int FuelLevel { get; set; }
    }
}