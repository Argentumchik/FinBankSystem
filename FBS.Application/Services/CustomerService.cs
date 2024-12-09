using FBS.Core.DTOs;
using FBS.Core.Interfaces;
using FBS.Core.Models;

namespace FBS.Application.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<List<Customer>> GetCustomers()
    {
        return await _customerRepository.Get();
    }

    public async Task<Customer> GetCustomerById(Guid id)
    {
        return await _customerRepository.GetById(id);
    }

    public async Task<Guid> CreateCustomer(CustomerCreateRequest request)
    {
        return await _customerRepository.Create(request);
    }

    public async Task<Guid> UpdateCustomer(Guid id, CustomerUpdateRequest request)
    {
        return await _customerRepository.Update(id, request);
    }

    public async Task<Guid> DeleteCustomer(Guid id)
    {
        return await _customerRepository.Delete(id);
    }
}