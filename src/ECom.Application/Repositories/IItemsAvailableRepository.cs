using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IItemsAvailableRepository
    {
        Task<ItemsAvailable> GetByIdAsync(object id);
        Task<IEnumerable<ItemsAvailable>> ListAsync();
        Task AddAsync(ItemsAvailable entity);
        Task UpdateAsync(ItemsAvailable entity);
        Task DeleteAsync(object id);
    }
}