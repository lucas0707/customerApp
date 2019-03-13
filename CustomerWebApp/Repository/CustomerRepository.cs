using CustomerWebApp.Models;
using CustomerWebApp.Repository.Context;
using CustomerWebApp.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWebApp.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerWebAppContext _context;

        public CustomerRepository(CustomerWebAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customer;
        }

        public async Task<Customer> GetById(Guid id)
        {
            return await _context.Customer.FindAsync(id);
        }

        public async Task<Customer> Create(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await GetById(id);
            if (customer == null)
            {
                throw new Exception("Customer not found.");
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return new NoContentResult();
        }

        public async Task<Customer> Update(Customer customer, Guid id)
        {
            _context.Entry(customer).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return customer;
        }
    }
}
