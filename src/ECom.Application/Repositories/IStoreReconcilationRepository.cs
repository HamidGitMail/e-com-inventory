using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IStoreReconcilationRepository
    {
        Task<StoreReconcilation> GetByIdAsync(object id);
        Task<IEnumerable<StoreReconcilation>> ListAsync();
        Task AddAsync(StoreReconcilation entity);
        Task UpdateAsync(StoreReconcilation entity);
        Task DeleteAsync(object id);
    }
}