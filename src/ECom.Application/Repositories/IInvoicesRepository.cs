using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IInvoicesRepository
    {
        Task<Invoices> GetByIdAsync(object id);
        Task<IEnumerable<Invoices>> ListAsync();
        Task AddAsync(Invoices entity);
        Task UpdateAsync(Invoices entity);
        Task DeleteAsync(object id);
    }
}