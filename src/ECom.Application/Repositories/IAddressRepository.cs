using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetByIdAsync(int id);
        Task<IEnumerable<Address>> ListAsync();
        Task AddAsync(Address entity);
        Task UpdateAsync(Address entity);
        Task DeleteAsync(int id);
    }
}