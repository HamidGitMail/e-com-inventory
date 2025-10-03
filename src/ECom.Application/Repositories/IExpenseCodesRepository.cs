using ECom.Domain.Models;

namespace ECom.Application.Repositories
{
    // Repository interface for ExpenseCodes
    public interface IExpenseCodesRepository
    {
        Task<ExpenseCodes> GetByIdAsync(object id);
        Task<IEnumerable<ExpenseCodes>> ListAsync();
        Task AddAsync(ExpenseCodes entity);
        Task UpdateAsync(ExpenseCodes entity);
        Task DeleteAsync(object id);
    }
}