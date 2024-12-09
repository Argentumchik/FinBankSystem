namespace FBS.Core.DTOs;

public record CustomerCreateRequest(
    string? FirstName, 
    string? LastName, 
    string? PhoneNumber, 
    string? Email, 
    DateTime DateOfBirth);