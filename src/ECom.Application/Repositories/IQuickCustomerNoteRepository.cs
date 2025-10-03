using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IQuickCustomerNoteRepository
    {
        Task<QuickCustomerNote> GetByIdAsync(object id);
        Task<IEnumerable<QuickCustomerNote>> ListAsync();
        Task AddAsync(QuickCustomerNote entity);
        Task UpdateAsync(QuickCustomerNote entity);
        Task DeleteAsync(object id);
    }
}