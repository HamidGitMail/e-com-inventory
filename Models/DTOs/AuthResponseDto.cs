namespace HCS_Inventory_Api.Models.DTOs;

public class AuthResponseDto
{
    public string Token { get; set; } = string.Empty;
    public string LoginName { get; set; } = string.Empty;
    public DateTime ExpiresAt { get; set; }
}
