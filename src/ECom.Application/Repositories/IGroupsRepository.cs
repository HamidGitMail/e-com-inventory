using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IGroupsRepository
    {
        Task<Groups> GetByIdAsync(object id);
        Task<IEnumerable<Groups>> ListAsync();
        Task AddAsync(Groups entity);
        Task UpdateAsync(Groups entity);
        Task DeleteAsync(object id);
    }
}