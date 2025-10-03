using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IAccountsRepository
    {
        Task<Accounts> GetByIdAsync(string id);
        Task<IEnumerable<Accounts>> ListAsync();
        Task AddAsync(Accounts entity);
        Task UpdateAsync(Accounts entity);
        Task DeleteAsync(string id);
    }
}