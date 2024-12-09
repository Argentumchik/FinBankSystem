namespace FBS.Core.DTOs;

public record CustomerUpdateRequest(
    string? FirstName, 
    string? LastName, 
    string? PhoneNumber, 
    string? Email);