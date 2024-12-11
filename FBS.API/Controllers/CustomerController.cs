using FBS.Core.DTOs;
using FBS.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBS.API.Controllers;

[ApiController]
[Route("api/customers")]
[Authorize]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CustomerResponseWithId>>> GetCustomers()
    {
        var customers = await _customerService.GetCustomers();

        var response = customers.Select(c => new CustomerResponseWithId
        (
            c.Id,
            c.FirstName,
            c.LastName,
            c.PhoneNumber,
            c.Email,
            c.DateOfBirth
        ));

        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CustomerResponse>> GetCustomerById(Guid id)
    {
        var customer = await _customerService.GetCustomerById(id);

        var response = new CustomerResponse
        (
            customer.FirstName,
            customer.LastName,
            customer.PhoneNumber,
            customer.Email,
            customer.DateOfBirth
        );

        return Ok(response);
    }

    [HttpPost("create")]
    public async Task<ActionResult<Guid>> CreateCustomer([FromBody]CustomerCreateRequest request)
    {
        var customerId = await _customerService.CreateCustomer(request);

        return Ok(customerId);
    }

    [HttpPut("update/{id:guid}")]
    public async Task<ActionResult<Guid>> UpdateCustomer(Guid id, CustomerUpdateRequest request)
    {
        var customerId = await _customerService.UpdateCustomer(id, request);

        return Ok(customerId);
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<ActionResult<Guid>> DeleteCustomer(Guid id)
    {
        var customerId = await _customerService.DeleteCustomer(id);

        return Ok(customerId);
    }
}