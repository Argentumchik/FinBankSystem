namespace FBS.Core.Models;

public class User
{
    public Guid Id { get; private set; }
    
    public string? UserName { get; private set; }
    
    public string? PasswordHash { get; private set; }
    
    public string? Email { get; private set; }

    private User(Guid id, string? userName, string? passwordHash, string? email)
    {
        Id = id;
        UserName = userName;
        PasswordHash = passwordHash;
        Email = email;
    }

    public static User Create(Guid id, string? userName, string? passwordHash, string? email)
    {
        return new User(id, userName, passwordHash, email);
    }
}