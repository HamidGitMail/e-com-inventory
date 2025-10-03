using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IBillPaymentsRepository
    {
        Task<BillPayments> GetByIdAsync(object id);
        Task<IEnumerable<BillPayments>> ListAsync();
        Task AddAsync(BillPayments entity);
        Task UpdateAsync(BillPayments entity);
        Task DeleteAsync(object id);
    }
}