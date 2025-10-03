using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    // Repository interface for CustomLists
    public interface ICustomListsRepository
    {
        Task<CustomLists> GetByIdAsync(object id);
        Task<IEnumerable<CustomLists>> ListAsync();
        Task AddAsync(CustomLists entity);
        Task UpdateAsync(CustomLists entity);
        Task DeleteAsync(object id);
    }
}