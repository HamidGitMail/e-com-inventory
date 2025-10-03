using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IGlobalSettingRepository
    {
        Task<GlobalSetting> GetByIdAsync(object id);
        Task<IEnumerable<GlobalSetting>> ListAsync();
        Task AddAsync(GlobalSetting entity);
        Task UpdateAsync(GlobalSetting entity);
        Task DeleteAsync(object id);
    }
}