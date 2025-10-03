using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IInvoiceDetailsRepository
    {
        Task<InvoiceDetails> GetByIdAsync(object id);
        Task<IEnumerable<InvoiceDetails>> ListAsync();
        Task AddAsync(InvoiceDetails entity);
        Task UpdateAsync(InvoiceDetails entity);
        Task DeleteAsync(object id);
    }
}