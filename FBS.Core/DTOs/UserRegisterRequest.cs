namespace FBS.Core.DTOs;

public record UserRegisterRequest(
    string? UserName,
    string? Email,
    string? Password,
    string? ConfirmPassword);