using AutoMapper;
using FBS.Core.Interfaces;
using FBS.Core.Models;
using FBS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FBS.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly BankDbContext _context;
    private readonly IMapper _mapper;

    public UserRepository(BankDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Add(User user)
    {
        var userEntity = _mapper.Map<UserEntity>(user);

        await _context.Users.AddAsync(userEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<User> GetByEmail(string? email)
    {
        var userEntity = await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email) ?? throw new Exception();

        return _mapper.Map<User>(userEntity);
    }
}