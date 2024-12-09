namespace FBS.Core.Models;

public class Customer
{
    public Guid Id { get; }
    
    public string? FirstName { get; }
    
    public string? LastName { get; }
    
    public string? PhoneNumber { get; }
    
    public string? Email { get; }
    
    public DateTime DateOfBirth { get; }

    private Customer(Guid id,
                     string? firstName, 
                     string? lastName, 
                     string? phoneNumber, 
                     string? email, 
                     DateTime dateOfBirth)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    public static Customer Create(Guid id, 
                           string? firstName, 
                           string? lastName, 
                           string? phoneNumber, 
                           string? email, 
                           DateTime dateOfBirth)
    {
        return new Customer(id, firstName, lastName, phoneNumber, email, dateOfBirth);
    }
}