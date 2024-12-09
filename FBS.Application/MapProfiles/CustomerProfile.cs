using AutoMapper;
using FBS.Core.Models;
using FBS.Infrastructure.Entities;

namespace FBS.Application.MapProfiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerEntity>().ReverseMap();
    }
}