namespace FBS.Core.DTOs;

public record UserLoginRequest(
    string? Email,
    string? Password);