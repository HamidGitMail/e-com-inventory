using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IQuickDistributorNoteRepository
    {
        Task<QuickDistributorNote> GetByIdAsync(object id);
        Task<IEnumerable<QuickDistributorNote>> ListAsync();
        Task AddAsync(QuickDistributorNote entity);
        Task UpdateAsync(QuickDistributorNote entity);
        Task DeleteAsync(object id);
    }
}