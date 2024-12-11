using FBS.Core.DTOs;
using FBS.Core.Models;

namespace FBS.Core.Interfaces;

public interface IUserService
{
    Task<User> Register(UserRegisterRequest request);
    Task<string> Login(UserLoginRequest request);
}