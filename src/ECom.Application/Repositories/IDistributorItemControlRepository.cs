using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    // Repository interface for DistributorItemControl
    public interface IDistributorItemControlRepository
    {
        Task<DistributorItemControl> GetByIdAsync(object id);
        Task<IEnumerable<DistributorItemControl>> ListAsync();
        Task AddAsync(DistributorItemControl entity);
        Task UpdateAsync(DistributorItemControl entity);
        Task DeleteAsync(object id);
    }
}