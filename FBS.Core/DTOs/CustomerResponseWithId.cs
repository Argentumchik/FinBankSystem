namespace FBS.Core.DTOs;

public record CustomerResponseWithId(
    Guid Id,
    string? FirstName, 
    string? LastName, 
    string? PhoneNumber, 
    string? Email, 
    DateTime DateOfBirth);