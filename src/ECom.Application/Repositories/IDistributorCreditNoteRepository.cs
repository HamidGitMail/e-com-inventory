using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IDistributorCreditNoteRepository
    {
        Task<DistributorCreditNote> GetByIdAsync(object id);
        Task<IEnumerable<DistributorCreditNote>> ListAsync();
        Task AddAsync(DistributorCreditNote entity);
        Task UpdateAsync(DistributorCreditNote entity);
        Task DeleteAsync(object id);
    }
}