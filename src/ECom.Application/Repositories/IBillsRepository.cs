using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IBillsRepository
    {
        Task<Bills> GetByIdAsync(string billNumber, string accountId);
        Task<IEnumerable<Bills>> ListAsync();
        Task AddAsync(Bills entity);
        Task UpdateAsync(Bills entity);
        Task DeleteAsync(string billNumber, string accountId);
    }
}