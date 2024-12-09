using FBS.Core.DTOs;
using FBS.Core.Models;

namespace FBS.Core.Interfaces;

public interface ICustomerService
{
    Task<List<Customer>> GetCustomers();
    Task<Customer> GetCustomerById(Guid id);
    Task<Guid> CreateCustomer(CustomerCreateRequest request);
    Task<Guid> UpdateCustomer(Guid id, CustomerUpdateRequest request);
    Task<Guid> DeleteCustomer(Guid id);
}