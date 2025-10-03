namespace HCS_Inventory_Api.Repositories;

using HCS_Inventory_Api.Models;

public interface IUserRepository
{
    Task<User?> GetByLoginNameAsync(string loginName);
    Task<bool> CreateUserAsync(User user);
    Task<bool> UserExistsAsync(string loginName);
}