using FBS.Core.Models;

namespace FBS.Core.Interfaces;

public interface IUserRepository
{
    Task Add(User user);
    Task<User> GetByEmail(string? email);
}