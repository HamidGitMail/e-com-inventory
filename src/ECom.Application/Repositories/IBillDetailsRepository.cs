using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IBillDetailsRepository
    {
        Task<BillDetails> GetByIdAsync(object id);
        Task<IEnumerable<BillDetails>> ListAsync();
        Task AddAsync(BillDetails entity);
        Task UpdateAsync(BillDetails entity);
        Task DeleteAsync(object id);
    }
}