using AutoMapper;
using FBS.Core.Models;
using FBS.Infrastructure.Entities;

namespace FBS.Application.MapProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserEntity>().ReverseMap();
    }
}