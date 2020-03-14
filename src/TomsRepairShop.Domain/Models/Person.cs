using System;

namespace TomsRepairShop.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}