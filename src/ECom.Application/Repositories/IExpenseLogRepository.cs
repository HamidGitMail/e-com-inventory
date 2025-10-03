using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    public interface IExpenseLogRepository
    {
        Task<ExpenseLog> GetByIdAsync(object id);
        Task<IEnumerable<ExpenseLog>> ListAsync();
        Task AddAsync(ExpenseLog entity);
        Task UpdateAsync(ExpenseLog entity);
        Task DeleteAsync(object id);
    }
}