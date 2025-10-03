using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IPaymentDetailsRepository
    {
        Task<PaymentDetails> GetByIdAsync(object id);
        Task<IEnumerable<PaymentDetails>> ListAsync();
        Task AddAsync(PaymentDetails entity);
        Task UpdateAsync(PaymentDetails entity);
        Task DeleteAsync(object id);
    }
}