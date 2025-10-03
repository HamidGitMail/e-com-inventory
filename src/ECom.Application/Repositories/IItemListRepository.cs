using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IItemListRepository
    {
        Task<ItemList> GetByIdAsync(object id);
        Task<IEnumerable<ItemList>> ListAsync();
        Task AddAsync(ItemList entity);
        Task UpdateAsync(ItemList entity);
        Task DeleteAsync(object id);
    }
}