using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ICustomerCreditNoteDetailsRepository
    {
        Task<CustomerCreditNoteDetails> GetByIdAsync(object id);
        Task<IEnumerable<CustomerCreditNoteDetails>> ListAsync();
        Task AddAsync(CustomerCreditNoteDetails entity);
        Task UpdateAsync(CustomerCreditNoteDetails entity);
        Task DeleteAsync(object id);
    }
}