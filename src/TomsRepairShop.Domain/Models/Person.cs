using System;

namespace TomsRepairShop.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int PersonTypeId { get; set; }
    }
}