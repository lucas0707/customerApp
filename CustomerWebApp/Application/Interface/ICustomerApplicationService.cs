using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWebApp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebApp.Application.Interface
{
    public interface ICustomerApplicationService
    {
        IList<CustomerDto> Get();
        Task<CustomerDto> GetById(Guid id);
        Task<CustomerDto> Create(CustomerDto customerDto);
        Task<IActionResult> Delete(Guid id);
        Task<CustomerDto> Update(CustomerDto customerDto, Guid id);
    }
}
