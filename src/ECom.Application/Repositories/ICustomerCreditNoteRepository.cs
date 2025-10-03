using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ICustomerCreditNoteRepository
    {
        Task<CustomerCreditNote> GetByIdAsync(object id);
        Task<IEnumerable<CustomerCreditNote>> ListAsync();
        Task AddAsync(CustomerCreditNote entity);
        Task UpdateAsync(CustomerCreditNote entity);
        Task DeleteAsync(object id);
    }
}