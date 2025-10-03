using System.Collections.Generic;
using System.Threading.Tasks;
using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IAddressTemplateRepository
    {
        Task<AddressTemplate> GetByIdAsync(string id);
        Task<IEnumerable<AddressTemplate>> ListAsync();
        Task AddAsync(AddressTemplate entity);
        Task UpdateAsync(AddressTemplate entity);
        Task DeleteAsync(string id);
    }
}