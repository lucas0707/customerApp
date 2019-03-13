using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWebApp.DTO;
using CustomerWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebApp.Repository.Interface
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Get();
        Task<Customer> GetById(Guid id);
        Task<Customer> Create(Customer customerDto);
        Task<IActionResult> Delete(Guid id);
        Task<Customer> Update(Customer customerDto, Guid id);
    }
}
