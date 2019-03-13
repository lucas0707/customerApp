using System;
using CustomerWebApp.Models;

namespace CustomerWebApp.DTO
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Gender { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public int? HouseNumber { get; set; }
        public string AditionalInformation { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
