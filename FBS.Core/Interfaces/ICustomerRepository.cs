using FBS.Core.DTOs;
using FBS.Core.Models;

namespace FBS.Core.Interfaces;

public interface ICustomerRepository
{
    Task<List<Customer>> Get();
    Task<Customer> GetById(Guid id);
    Task<Guid> Create(CustomerCreateRequest request);
    Task<Guid> Update(Guid id, CustomerUpdateRequest request);
    Task<Guid> Delete(Guid id);
}