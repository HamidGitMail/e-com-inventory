using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IDistributorCreditNoteDetailRepository
    {
        Task<DistributorCreditNoteDetail> GetByIdAsync(object id);
        Task<IEnumerable<DistributorCreditNoteDetail>> ListAsync();
        Task AddAsync(DistributorCreditNoteDetail entity);
        Task UpdateAsync(DistributorCreditNoteDetail entity);
        Task DeleteAsync(object id);
    }
}