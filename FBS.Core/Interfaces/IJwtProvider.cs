using FBS.Core.Models;

namespace FBS.Core.Interfaces;

public interface IJwtProvider
{
    string GenerateToken(User user);
}