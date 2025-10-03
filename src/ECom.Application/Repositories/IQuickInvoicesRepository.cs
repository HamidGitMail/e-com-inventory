using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IQuickInvoicesRepository
    {
        Task<QuickInvoices> GetByIdAsync(object id);
        Task<IEnumerable<QuickInvoices>> ListAsync();
        Task AddAsync(QuickInvoices entity);
        Task UpdateAsync(QuickInvoices entity);
        Task DeleteAsync(object id);
    }
}