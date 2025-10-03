using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IPaymentsRepository
    {
        Task<Payments> GetByIdAsync(object id);
        Task<IEnumerable<Payments>> ListAsync();
        Task AddAsync(Payments entity);
        Task UpdateAsync(Payments entity);
        Task DeleteAsync(object id);
    }
}