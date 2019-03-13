using System;
using CustomerWebApp.DTO;

namespace CustomerWebApp.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string name, DateTime? birthDay, int? gender)
        {
            ValidateName(name);
            ValidateBirthDate(birthDay);
            ValidateGender(gender);
        }

        private void ValidateGender(int? gender)
        {
            if (gender <= 1)
            {
                Gender = (Gender)gender;
            }
        }

        private void ValidateBirthDate(DateTime? birthDay)
        {
            if (birthDay != null )
            {
                BirthDate = birthDay.Value;
            }
        }

        private void ValidateName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public int? HouseNumber { get; set; }
        public string AditionalInformation { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }

        public void UpdateEntity(CustomerDto customerDto)
        {
            ValidateName(customerDto.Name);
            ValidateBirthDate(customerDto.BirthDate);
            ValidateGender(customerDto.Gender);
            PostalCode = customerDto.PostalCode;
            Address = customerDto.Address;
            HouseNumber = customerDto.HouseNumber;
            AditionalInformation = customerDto.AditionalInformation;
            Neighborhood = customerDto.Neighborhood;
            State = customerDto.State;
            City = customerDto.City;
        }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
