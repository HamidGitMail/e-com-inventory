using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ISettingsRepository
    {
        Task<Settings> GetByIdAsync(object id);
        Task<IEnumerable<Settings>> ListAsync();
        Task AddAsync(Settings entity);
        Task UpdateAsync(Settings entity);
        Task DeleteAsync(object id);
    }
}