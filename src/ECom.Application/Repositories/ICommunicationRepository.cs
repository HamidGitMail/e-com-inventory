using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface ICommunicationRepository
    {
        Task<Communication> GetByIdAsync(object id);
        Task<IEnumerable<Communication>> ListAsync();
        Task AddAsync(Communication entity);
        Task UpdateAsync(Communication entity);
        Task DeleteAsync(object id);
    }
}