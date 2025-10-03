using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ICutomLabelsRepository
    {
        Task<CutomLabels> GetByIdAsync(object id);
        Task<IEnumerable<CutomLabels>> ListAsync();
        Task AddAsync(CutomLabels entity);
        Task UpdateAsync(CutomLabels entity);
        Task DeleteAsync(object id);
    }
}