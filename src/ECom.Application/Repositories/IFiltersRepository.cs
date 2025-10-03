using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IFiltersRepository
    {
        Task<Filters> GetByIdAsync(object id);
        Task<IEnumerable<Filters>> ListAsync();
        Task AddAsync(Filters entity);
        Task UpdateAsync(Filters entity);
        Task DeleteAsync(object id);
    }
}