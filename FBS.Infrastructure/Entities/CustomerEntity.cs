namespace FBS.Infrastructure.Entities;

public class CustomerEntity
{
    public Guid Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? Email { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime UpdatedDate { get; set; }

    public UserEntity User { get; set; }

    public Guid UserId { get; set; }
}