using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IBillPaymentDetailsRepository
    {
        Task<BillPaymentDetails> GetByIdAsync(object id);
        Task<IEnumerable<BillPaymentDetails>> ListAsync();
        Task AddAsync(BillPaymentDetails entity);
        Task UpdateAsync(BillPaymentDetails entity);
        Task DeleteAsync(object id);
    }
}