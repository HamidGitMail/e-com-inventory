namespace HCS_Inventory_Api.Models;

public class User
{
    public string LoginName { get; set; } = string.Empty;
    public string LoginPassword { get; set; } = string.Empty;
    public string? ShopName { get; set; }
    public string? ShopAddress { get; set; }
    public string? ShopCity { get; set; }
    public string? ShopState { get; set; }
    public string? ShopPhone { get; set; }
    public string? ShopEmail { get; set; }
    public string? ShopPIN { get; set; }
    public string? Greeting { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LicenseNumber { get; set; }
    public string? GSTTINNumber { get; set; }
    public string? CSTNumber { get; set; }
    public bool IsDistributor { get; set; }
    public string? WebSite { get; set; }
}