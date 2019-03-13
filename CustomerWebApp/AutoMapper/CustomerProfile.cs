using AutoMapper;
using CustomerWebApp.DTO;
using CustomerWebApp.Models;

namespace CustomerWebApp.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}
