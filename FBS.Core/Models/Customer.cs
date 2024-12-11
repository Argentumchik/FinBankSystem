namespace FBS.Core.Models;

public class Customer
{
    public Guid Id { get; }
    
    public string? FirstName { get; }
    
    public string? LastName { get; }
    
    public string? PhoneNumber { get; }
    
    public string? Email { get; }
    
    public DateTime DateOfBirth { get; }
    
    public Guid UserId { get; }
    
    

    private Customer(Guid id,
                     string? firstName, 
                     string? lastName, 
                     string? phoneNumber, 
                     string? email, 
                     DateTime dateOfBirth,
                     Guid userId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        DateOfBirth = dateOfBirth;
        UserId = userId;
    }

    public static Customer Create(Guid id, 
                           string? firstName, 
                           string? lastName, 
                           string? phoneNumber, 
                           string? email, 
                           DateTime dateOfBirth,
                           Guid userId)
    {
        return new Customer(id, firstName, lastName, phoneNumber, email, dateOfBirth, userId);
    }
}