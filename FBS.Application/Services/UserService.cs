using FBS.Core.DTOs;
using FBS.Core.Interfaces;
using FBS.Core.Models;

namespace FBS.Application.Services;

public class UserService : IUserService
{
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _provider;

    public UserService(IPasswordHasher passwordHasher, IUserRepository userRepository, IJwtProvider provider)
    {
        _passwordHasher = passwordHasher;
        _userRepository = userRepository;
        _provider = provider;
    }

    public async Task<User> Register(UserRegisterRequest request)
    {
        var hashPassword = request.Password == request.ConfirmPassword
            ? _passwordHasher.Generate(request.Password)
            : null;

        if (string.IsNullOrEmpty(hashPassword))
        {
            throw new InvalidOperationException();
        }

        var user = User.Create(
            Guid.NewGuid(),
            request.UserName,
            hashPassword,
            request.Email);

        await _userRepository.Add(user);

        return user;
    }

    public async Task<string> Login(UserLoginRequest request)
    {
        var user = await _userRepository.GetByEmail(request.Email);

        var result = _passwordHasher.Verify(request.Password, user.PasswordHash);

        if (result == false)
        {
            throw new Exception();
        }

        var token = _provider.GenerateToken(user);

        return token;
    }
}