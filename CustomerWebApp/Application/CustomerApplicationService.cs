using AutoMapper;
using CustomerWebApp.Application.Interface;
using CustomerWebApp.DTO;
using CustomerWebApp.Models;
using CustomerWebApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebApp.Application
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerApplicationService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public IList<CustomerDto> Get()
        {
            var customers = _customerRepository.Get();
            var customersDtoList = customers.Select(customer => _mapper.Map<CustomerDto>(customer)).ToList();

            return customersDtoList;
        }

        public async Task<CustomerDto> GetById(Guid id)
        {
            var customer = await _customerRepository.GetById(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<CustomerDto> Create(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            var customerCreated = await _customerRepository.Create(customer);
            var customerCreatedDto = _mapper.Map<CustomerDto>(customerCreated);

            return customerCreatedDto;
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return await _customerRepository.Delete(id);
        }

        public async Task<CustomerDto> Update(CustomerDto customerDto, Guid id)
        {
            var customer = await _customerRepository.GetById(id);
            customer.UpdateEntity(customerDto);
            var updated = await _customerRepository.Update(customer, id);
            return _mapper.Map<CustomerDto>(updated);
        }
    }

}
