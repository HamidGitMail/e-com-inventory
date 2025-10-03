using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IFilterTypeRepository
    {
        Task<FilterType> GetByIdAsync(object id);
        Task<IEnumerable<FilterType>> ListAsync();
        Task AddAsync(FilterType entity);
        Task UpdateAsync(FilterType entity);
        Task DeleteAsync(object id);
    }
}