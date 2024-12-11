using AutoMapper;
using FBS.Core.DTOs;
using FBS.Core.Interfaces;
using FBS.Core.Models;
using FBS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FBS.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly BankDbContext _context;
    private readonly IMapper _mapper;

    public CustomerRepository(BankDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Customer>> Get()
    {
        var customerEntity = await _context.Customers
            .AsNoTracking()
            .ToListAsync();

        var customers = _mapper.Map<List<Customer>>(customerEntity);

        return customers;
    }

    public async Task<Customer> GetById(Guid id)
    {
        var customerEntity = await _context.Customers
            .FirstOrDefaultAsync(c => c.Id == id);

        var customer = _mapper.Map<Customer>(customerEntity);

        return customer;
    }

    public async Task<Guid> Create(CustomerCreateRequest request)
    {
        var customer = Customer.Create(
            Guid.NewGuid(),
            request.FirstName,
            request.LastName,
            request.PhoneNumber,
            request.Email,
            request.DateOfBirth,
            request.UserId);

        var customerEntity = _mapper.Map<CustomerEntity>(customer);

        await _context.Customers.AddAsync(customerEntity);
        await _context.SaveChangesAsync();

        return customerEntity.Id;
    }

    public async Task<Guid> Update(Guid id, CustomerUpdateRequest request)
    {
        await _context.Customers
            .Where(c => c.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(c => c.FirstName, c => request.FirstName)
                .SetProperty(c => c.LastName, c => request.LastName)
                .SetProperty(c => c.PhoneNumber, request.PhoneNumber)
                .SetProperty(c => c.Email, c => request.Email));

        return id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _context.Customers
            .Where(c => c.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }
}