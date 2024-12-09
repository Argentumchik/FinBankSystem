namespace FBS.Core.DTOs;

public record CustomerResponse(
    string? FirstName, 
    string? LastName, 
    string? PhoneNumber, 
    string? Email, 
    DateTime DateOfBirth);