namespace HCS_Inventory_Api.Models.DTOs;
public class RegisterDto
{
    public string LoginName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? ShopName { get; set; }
    public string? ShopEmail { get; set; }
    public string? ShopPhone { get; set; }
}
