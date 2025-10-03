using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IUsersRepository
    {
        Task<Users> GetByIdAsync(object id);
        Task<IEnumerable<Users>> ListAsync();
        Task AddAsync(Users entity);
        Task UpdateAsync(Users entity);
        Task DeleteAsync(object id);
    }
}