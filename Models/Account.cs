namespace HCS_Inventory_Api.Models;

public class Account
{
    public string Account_ID { get; set; } = string.Empty;
    public string? Salutation { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? Parent { get; set; }
    public string? GroupID { get; set; }
    public bool IsCustomer { get; set; }
    public string? Website { get; set; }
    public string? AccountMemo { get; set; }
    public decimal? RetainerAvailable { get; set; }
    public decimal? CreditAvailable { get; set; }
    public bool LockStatus { get; set; }
    public DateTime? LockDate { get; set; }
    public int? Status { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LicenseNumber { get; set; }
    public string? GSTTINNumber { get; set; }
    public string? CSTNumber { get; set; }
    public decimal? Balance { get; set; }
}