using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ICustomerItemControlRepository
    {
        Task<CustomerItemControl> GetByIdAsync(object id);
        Task<IEnumerable<CustomerItemControl>> ListAsync();
        Task AddAsync(CustomerItemControl entity);
        Task UpdateAsync(CustomerItemControl entity);
        Task DeleteAsync(object id);
    }
}