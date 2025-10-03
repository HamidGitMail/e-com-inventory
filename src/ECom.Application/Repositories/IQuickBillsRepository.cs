using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IQuickBillsRepository
    {
        Task<QuickBills> GetByIdAsync(object id);
        Task<IEnumerable<QuickBills>> ListAsync();
        Task AddAsync(QuickBills entity);
        Task UpdateAsync(QuickBills entity);
        Task DeleteAsync(object id);
    }
}