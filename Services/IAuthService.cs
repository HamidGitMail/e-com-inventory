namespace HCS_Inventory_Api.Services;

using HCS_Inventory_Api.Models.DTOs;

public interface IAuthService
{
    Task<AuthResponseDto?> LoginAsync(LoginDto loginDto);
    Task<AuthResponseDto?> RegisterAsync(RegisterDto registerDto);
}