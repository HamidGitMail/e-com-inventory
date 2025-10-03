namespace HCS_Inventory_Api.Repositories;

using HCS_Inventory_Api.Models;

public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetAllAccountsAsync();
    Task<Account?> GetAccountByIdAsync(string accountId);
    Task<bool> CreateAccountAsync(Account account);
    Task<bool> UpdateAccountAsync(Account account);
    Task<bool> DeleteAccountAsync(string accountId);
}