using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IGroupDetailRepository
    {
        Task<GroupDetail> GetByIdAsync(object id);
        Task<IEnumerable<GroupDetail>> ListAsync();
        Task AddAsync(GroupDetail entity);
        Task UpdateAsync(GroupDetail entity);
        Task DeleteAsync(object id);
    }
}